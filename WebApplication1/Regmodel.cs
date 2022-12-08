namespace WebApplication1
{
    public class Regmodel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Depid { get; set; }
        public int Desid { get; set; }
        public int Salary { get; set; }
        public string Mail { get; set; }
        public int Phone { get; set; }

    }
    public class Regmodeldept
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Regmodeldes
    {
        public int Id { get; set; }
        public string Designation { get; set; }
    }

}
