using System;

namespace Pattern
{

    class Preschooler { }
    class Underage { }
    class Adult { }
    class Senior { }

    class Car
    {
        public string Model { get; set; }
        public DateTime ProducedAt { get; set; }

        
    }

    class OrderItem
    {
        public int Amount { get; set; }
        public int Price { get; set; }
    }



    
    class MainApp
    {

        static double GetPrice(OrderItem orderItem) => orderItem switch
        {
            OrderItem { Amount: 0 } or OrderItem { Price: 0 }
            => 0.0,
            OrderItem { Amount: >= 100 } and OrderItem { Price: >= 10_000 }
            => orderItem.Amount * orderItem.Price * 0.8,
            not OrderItem { Amount: < 100 }
            => orderItem.Amount * orderItem.Price * 0.9,
            _ => orderItem.Amount * orderItem.Price,
        };

        static int CalculateFee(object visitor)
        {
            return visitor switch
            {
                Underage => 100,
                Adult => 500,
                Senior => 200,
                _ => throw new ArgumentException($"Prohibited age: {visitor.GetType()}", nameof(visitor)),
            };
        }

        static string GetNickName(Car car)
        {
            var GenerateMessage = (Car car, string nickName) =>
            $"{car.Model} produced in {car.ProducedAt.Year} is {nickName}";

            if (car is Car { Model: "Mustang", ProducedAt.Year: 1967 })
            {
                return GenerateMessage(car, "Fastback");
            }
            else if (car is Car { Model: "Mustang", ProducedAt.Year: 1976 })
            {
                return GenerateMessage(car, "Cobra II");
            }
            else
            {
                return GenerateMessage(car, "Unknown");
            }
        }

        static bool IsPassed(double score) => score switch
        {
            < 60 => false,
            _ => true,
        };

        static string GetGrade(double score) => score switch
        {
            < 60 => "F",
            >= 60 and < 70 => "D",
            >= 70 and < 80 => "C",
            >= 80 and < 90 => "B",
            _ => "A",
        };



        static void Main(string[] args)
        {
            object foo = 23;
            if (foo is int bar)
            {
                Console.WriteLine(bar);
            }

            if (foo is int)
            {
                Console.WriteLine(foo);
            }

            Console.WriteLine($"Fee for a Senior: {CalculateFee(new Senior())}");
            Console.WriteLine($"Fee for a adult: {CalculateFee(new Adult())}");

            var GetCountryCode = (string nation) => nation switch
            {
                "KR" => 82,
                "US" => 1,
                "UK" => 44,
                _ => throw new ArgumentException("Not Supported Code")
            };
            Console.WriteLine(GetCountryCode("KR"));
            Console.WriteLine(GetCountryCode("US"));
            Console.WriteLine(GetCountryCode("UK"));

            object? obj = null;

            if (obj is null)
            {
                Console.WriteLine("null");
            }

            Console.WriteLine(
                GetNickName(
                    new Car() { Model = "Mustang", ProducedAt = new DateTime(1967, 11, 23) }));

        }
    }
}