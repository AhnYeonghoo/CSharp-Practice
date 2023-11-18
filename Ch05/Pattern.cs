using System;
using System.Collections;

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



    struct Audience
    {
        public bool IsCitizen { get; init; }
        public int Age { get; init; }

        public Audience(bool isCitizen, int age)
        {
            IsCitizen = isCitizen;
            Age = age;
        }

        public void Deconstruct(out bool isCitizen, out int age)
        {
            isCitizen = IsCitizen;
            age = Age;
        }

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

            Tuple<string, int> itemPrice = new Tuple<string, int>("espresso", 3000);
            
            if (itemPrice is ("espresso",  < 5000))
            {
                Console.WriteLine("the coffe is affordable");
            }

            var Calculate = (Audience audience) => audience switch
            {
                (true, < 19) => 100,
                (true, _) => 200,
                (false, < 19) => 200,
                (false, _) => 400,
            };

            var a1 = new Audience(true, 10);
            Console.WriteLine($"내국인: {a1.IsCitizen} 나이 : {a1.Age} 요금: {Calculate(a1)}");

            var IsPassed =
                (int[] scores) => scores.Sum() / scores.Length is var average
                && Array.TrueForAll(scores, (score) => score >= 60)
                && average >= 60;

            int[] scores1 = { 90, 80, 60, 80, 70 };
            Console.WriteLine($"{string.Join(",", scores1)}: Pass:{IsPassed(scores1)}");

            var match = (int[] array) => array is [int, > 10, _];

            var GetStatistics = (List<object[]> records) =>
            {
                var statistics = new Dictionary<string, int>();

                foreach (var record in records)
                {
                    var (contentType, contentViews) = record switch
                    {
                        [_, "COMEDY", .., var views] => ("COMEDY", views),
                        [_, "SF", .., var views] => ("ACTION", views),
                        [_, .., var amount] => ("ETC", amount),
                        _ => ("ETC", 0),
                    };

                    if (statistics.ContainsKey(contentType))
                    {
                        statistics[contentType] += (int)contentViews;
                    }
                    else
                    {
                        statistics.Add(contentType, (int)contentViews);
                    }
                }
                    return statistics;
            };

            List<object[]> MovieRecords = new List<object[]>()
            {
                new object[] {0, "COMEDY", "Spy", 2015, 10_000},
                new object[] {1, "COMEDY", "Scary Movie", 20_000},
                new object[] {2, "SF", "Avengers: Inifinte War", 100_000},
            };

            var statistics = GetStatistics(MovieRecords);

            foreach (var s in statistics)
            {
                Console.WriteLine($"{s.Key}: {s.Value}");
            }
        }
    }
}