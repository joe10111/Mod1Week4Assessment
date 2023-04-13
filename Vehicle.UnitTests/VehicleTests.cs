namespace Vehicle.UnitTests
{
    public class VehicleTests
    {
         // A test to check if all properties initialize correctly in the Vehicle constructor 
        [Fact] 
        public void WhenCreated_HasCorrectProperties()
        {
            Vehicle megansCar = new Vehicle(4, "Green");

            Assert.Equal(4, megansCar.NumberOfWheels);
            Assert.Equal("Green", megansCar.Color);
            Assert.Equal(0, megansCar.MilesDriven);
        }

         // A test to check if the correct summary string is generated and returned
        [Fact]
        public void Summary_ReturnsInfoAboutVehicle()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");
             // Also updated the expected to reflect string formatt of summary()
            var expected = "This Blue vehicle has 2 wheels, and has driven 0 miles.";

            // Aded assert bellow checking expected vs summary call on andysBike
            Assert.Equal(expected, andysBike.Sumary());
        }

         //A test to check if the drive method is correctly incrementing the MilesDriven property
        [Fact] 
        public void Test_Drive_Method()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");

            andysBike.Drive();

            var expected = 5;
            Assert.Equal(expected, andysBike.MilesDriven);
        }

         // A test to check if the paint method is working correctly with re-assigning the Color property. 
        [Fact] 
        public void Test_Paint_Method()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");
            andysBike.Paint("Red");

            var expected = "Red";
            Assert.Equal(expected, andysBike.Color);
        }
    }
}
