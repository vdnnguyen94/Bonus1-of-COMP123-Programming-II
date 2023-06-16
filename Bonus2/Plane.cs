using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus2
{
    class Plane
    {
        string Manufacture { get; set; }
        string Model { get; set; }
        int Capacity { get; set; }
        string Type { get; set; }
        string SerialNumber { get; set; }
        public Plane()
        {
            Manufacture = "unknown";
            Model = "unknown";
            Capacity = 0;
            Type = "unassigned";
            SerialNumber = "00000";
        }
        public Plane(string manufacture, string model, int capacity, string type, string serialNumber)
        {
            Manufacture = manufacture;
            Model = model;
            Capacity = capacity;
            Type = type;
            SerialNumber = serialNumber;
        }
        public override string ToString()
        {
            return $"Manufacture: {Manufacture}, Model: {Model}, Capacity: {Capacity}, Type: {Type}, SerialNumber: {SerialNumber}.";
        }
        public bool HasCapcity(int capacity)
        {

            return (Capacity >= capacity) ? true : false;
        }
    }
}
