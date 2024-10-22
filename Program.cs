using System.Dynamic;

Odometer odometer = new Odometer();

odometer.add(300,20);

Console.WriteLine(odometer.toString());

Odometer odometer1 = new Odometer(30000,4000);

Console.WriteLine(odometer1.toString());

odometer1.reset();

odometer1.add(1, 1);

Console.WriteLine(odometer1.toString());

class Odometer {
    private double milage;
    private double fuelUsed;

    public Odometer() {
        milage = 0;
        fuelUsed = 0;
    }

    public Odometer(int _milage, int _fuelUsed)
    {
        milage = _milage;
        fuelUsed = _fuelUsed;
    }

    public void reset() {
        milage = 0;
        fuelUsed=0;
    }

    public void add(int _milage, int _fuelUsed) { milage+= _milage; fuelUsed += _fuelUsed; }

    public double getMilesPerGallon() { return milage / fuelUsed; }

    public string toString()
    {
        return "Odometer Readings: milage = " + milage + ", fuel used in gallons = " + fuelUsed + ", miles per gallon = " + getMilesPerGallon() + ".";
    }
}