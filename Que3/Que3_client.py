# EasyDrive Car Rental - TCP Client
# Collects customer registration information and sends it to the server
# Receives and displays the unique registration number from the server

import socket
import json

def collect_customer_info():
    print("\nEasyDrive Customer Registration")
    print("Please provide the following information:\n")

    name = input("Full Name              : ").strip()
    address = input("Address                : ").strip()
    pps_number = input("PPS Number             : ").strip()
    driving_license = input("Driving License (filename/number) : ").strip()

    customer_data = {
        "name": name,
        "address": address,
        "pps_number": pps_number,
        "driving_license": driving_license
    }

    return customer_data

def TCP_client():
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    host = '127.0.0.1'
    port = 9090

    try:
        sock.connect((host, port))
        print("\nClient is connected to EasyDrive server....")

        customer_data = collect_customer_info()

        json_data = json.dumps(customer_data)
        sock.sendall(json_data.encode())
        print("\nRegistration data sent to server.")

        response = sock.recv(1024)
        reg_no = response.decode()

        print("\nRegistration successful!")
        print("Your Registration Number : ", reg_no)
        print("Please keep this number for your records.")

    except ConnectionRefusedError:
        print("Connection Refused. Please ensure the server is running.")
    except ConnectionAbortedError:
        print("Connection is aborted....")
    except ConnectionError:
        print("Connection Error.....")
    except Exception as e:
        print("Error: ", e)
    finally:
        sock.close()

def main():
    print("- - - - - EasyDrive TCP Client - - - - -")
    TCP_client()

if __name__ == "__main__":
    main()
