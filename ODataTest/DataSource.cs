using System.Collections.Generic;

namespace ODataTest
{
    public class DataSource
    {
        private static IList<Parent> Data { get; set; }


        public static IList<Parent> GetData()
        {
            if (Data != null)
            {
                return Data;
            }

            Data = new List<Parent>();

            // parent #1
            var parent = new Parent
            {
                Id = 1,
                Name = "Data1",
                Childs = new List<Child>
                {
                    new Child
                    {
                        Id = 1, Foo = "child1", ChildOfChild = new ChildOfChild {Id = 1, Colour = "Red"}
                    },
                    new Child
                    {
                        Id = 2, Foo = "child2", ChildOfChild = new ChildOfChild {Id = 2, Colour = "Green"}
                    }
                }
            };
            Data.Add(parent);

            // parent #2
            parent = new Parent
            {
                Id = 2,
                Name = "Parent2",
                Childs = new List<Child>
                {
                    new Child {Id = 10, Foo = "Hi", ChildOfChild = new ChildOfChild {Id = 10, Colour = "Pink"}},
                    new Child
                    {
                        Id = 11,
                        Foo = "Another",
                        ChildOfChild = new ChildOfChild {Id = 11, Colour = "Yellow"}
                    }
                }
            };

            Data.Add(parent);

            return Data;
        }
    }
}