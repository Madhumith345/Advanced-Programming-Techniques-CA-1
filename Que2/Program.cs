// Periodic Table - First 30 Elements
// Stores elements in a Dictionary and allows lookup by atomic number

class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int, Element> periodicTable = new Dictionary<int, Element>();

        periodicTable.Add(1,  new Element(1,  "Hydrogen",     "H",  "Nonmetal",          "Lightest element, highly flammable gas, most abundant in the universe"));
        periodicTable.Add(2,  new Element(2,  "Helium",       "He", "Noble Gas",          "Colourless, odourless, non-reactive gas used in balloons and cooling"));
        periodicTable.Add(3,  new Element(3,  "Lithium",      "Li", "Alkali Metal",       "Soft, silvery metal used in batteries and mood-stabilising medicine"));
        periodicTable.Add(4,  new Element(4,  "Beryllium",    "Be", "Alkaline Earth Metal","Hard, grey metal used in aerospace alloys and X-ray windows"));
        periodicTable.Add(5,  new Element(5,  "Boron",        "B",  "Metalloid",          "Hard solid used in glass, ceramics and boron neutron capture therapy"));
        periodicTable.Add(6,  new Element(6,  "Carbon",       "C",  "Nonmetal",           "Basis of all organic chemistry, exists as diamond and graphite"));
        periodicTable.Add(7,  new Element(7,  "Nitrogen",     "N",  "Nonmetal",           "Makes up 78% of Earth's atmosphere, essential for amino acids"));
        periodicTable.Add(8,  new Element(8,  "Oxygen",       "O",  "Nonmetal",           "Essential for respiration and combustion, second most abundant in atmosphere"));
        periodicTable.Add(9,  new Element(9,  "Fluorine",     "F",  "Halogen",            "Most electronegative element, used in toothpaste and non-stick coatings"));
        periodicTable.Add(10, new Element(10, "Neon",         "Ne", "Noble Gas",          "Colourless gas famous for its bright red-orange glow in neon signs"));
        periodicTable.Add(11, new Element(11, "Sodium",       "Na", "Alkali Metal",       "Highly reactive metal, reacts violently with water, used in table salt"));
        periodicTable.Add(12, new Element(12, "Magnesium",    "Mg", "Alkaline Earth Metal","Light structural metal used in alloys, fireworks and medicine"));
        periodicTable.Add(13, new Element(13, "Aluminium",    "Al", "Post-transition Metal","Most abundant metal in Earth's crust, widely used in packaging"));
        periodicTable.Add(14, new Element(14, "Silicon",      "Si", "Metalloid",          "Semiconductor used in computer chips and solar cells"));
        periodicTable.Add(15, new Element(15, "Phosphorus",   "P",  "Nonmetal",           "Essential for DNA and ATP, used in fertilisers and safety matches"));
        periodicTable.Add(16, new Element(16, "Sulfur",       "S",  "Nonmetal",           "Yellow solid found near volcanoes, used in rubber vulcanisation"));
        periodicTable.Add(17, new Element(17, "Chlorine",     "Cl", "Halogen",            "Toxic green gas used as a disinfectant in water treatment"));
        periodicTable.Add(18, new Element(18, "Argon",        "Ar", "Noble Gas",          "Most common noble gas in the atmosphere, used in welding shielding"));
        periodicTable.Add(19, new Element(19, "Potassium",    "K",  "Alkali Metal",       "Soft metal essential for nerve function, reacts with water"));
        periodicTable.Add(20, new Element(20, "Calcium",      "Ca", "Alkaline Earth Metal","Essential for bones and teeth, used in cement and chalk"));
        periodicTable.Add(21, new Element(21, "Scandium",     "Sc", "Transition Metal",   "Rare silvery metal used in aluminium-scandium alloys for aerospace"));
        periodicTable.Add(22, new Element(22, "Titanium",     "Ti", "Transition Metal",   "Strong, lightweight metal used in aircraft, implants and paints"));
        periodicTable.Add(23, new Element(23, "Vanadium",     "V",  "Transition Metal",   "Hard metal used to strengthen steel, found in some foods"));
        periodicTable.Add(24, new Element(24, "Chromium",     "Cr", "Transition Metal",   "Shiny metal used in stainless steel and chrome plating"));
        periodicTable.Add(25, new Element(25, "Manganese",    "Mn", "Transition Metal",   "Essential trace element, used in steel production and batteries"));
        periodicTable.Add(26, new Element(26, "Iron",         "Fe", "Transition Metal",   "Most used metal in industry, primary component of steel"));
        periodicTable.Add(27, new Element(27, "Cobalt",       "Co", "Transition Metal",   "Hard magnetic metal used in alloys, batteries and cancer treatment"));
        periodicTable.Add(28, new Element(28, "Nickel",       "Ni", "Transition Metal",   "Corrosion-resistant metal used in coins, batteries and alloys"));
        periodicTable.Add(29, new Element(29, "Copper",       "Cu", "Transition Metal",   "Excellent electrical conductor, used in wiring and plumbing"));
        periodicTable.Add(30, new Element(30, "Zinc",         "Zn", "Transition Metal",   "Protective coating for steel, essential mineral for immune function"));

        Console.WriteLine("\nHi there! Happy to help!");

        bool continueLoop = true;
        while (continueLoop)
        {
            Console.Write("\nProvide atomic number of the element: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int atomicNum) && periodicTable.ContainsKey(atomicNum))
            {
                periodicTable[atomicNum].ShowElement();
            }
            else
            {
                Console.WriteLine("Invalid atomic number. Please enter a number between 1 and 30.");
            }

            Console.Write("\nDo you want to know more elements [y/n]? ");
            string? again = Console.ReadLine();

            if (again != null && again.ToLower() == "n")
            {
                continueLoop = false;
                Console.WriteLine("\nThanks!");
            }
        }
    }
}
