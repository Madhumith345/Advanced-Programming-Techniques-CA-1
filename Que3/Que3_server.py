# EasyDrive Car Rental - TCP Server
# Receives customer registration data, stores in SQLite database,
# generates a unique registration number and sends it back to the client

import socket
import sqlite3
import json
import time

DB_NAME = "easydrive.db"

def setup_database():
    con = sqlite3.connect(DB_NAME)
    cur = con.cursor()
    cur.execute("""
        CREATE TABLE IF NOT EXISTS Customers (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            registration_no TEXT,
            name TEXT,
            address TEXT,
            pps_number TEXT,
            driving_license TEXT,
            registered_at TEXT
        )
    """)
    con.commit()
    cur.close()
    con.close()
    print("Database is ready.")

def generate_registration_no():
    timestamp = str(int(time.time() * 1000))[-6:]
    return "REG" + timestamp

def store_customer(data):
    con = sqlite3.connect(DB_NAME)
    cur = con.cursor()

    reg_no = generate_registration_no()
    registered_at = time.strftime("%Y-%m-%d %H:%M:%S")

    cur.execute("""
        INSERT INTO Customers (registration_no, name, address, pps_number, driving_license, registered_at)
        VALUES (?, ?, ?, ?, ?, ?)
    """, (reg_no, data["name"], data["address"], data["pps_number"], data["driving_license"], registered_at))

    con.commit()
    print("\nCustomer record saved to database.")
    print("Name             : ", data["name"])
    print("Registration No  : ", reg_no)

    cur.close()
    con.close()
    return reg_no

def TCP_server():
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    sock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
    host = '127.0.0.1'
    port = 9090

    try:
        sock.bind((host, port))
        print("Server is ready....")

        sock.listen()
        print("Server is listening for connection...")

        sock.settimeout(120)

        con, addr = sock.accept()
        print("Server is connected to ", addr)

        data = con.recv(4096)
        customer_data = json.loads(data.decode())
        print("\nData received from client.")

        reg_no = store_customer(customer_data)

        con.sendall(reg_no.encode())
        con.close()

    except TimeoutError:
        print("Time out error...")
    except OSError as e:
        print("OS Error: ", e)
    except KeyboardInterrupt:
        print("Process is killed...")
    except Exception as e:
        print("Error: ", e)
    finally:
        sock.close()

def main():
    print("\n- - - - - EasyDrive TCP Server - - - - -\n")
    setup_database()
    TCP_server()

if __name__ == "__main__":
    main()
