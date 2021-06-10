using System.Collections.Generic;

namespace ODataTest
{
    public class Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Child> Childs { get; set; }
    }
}