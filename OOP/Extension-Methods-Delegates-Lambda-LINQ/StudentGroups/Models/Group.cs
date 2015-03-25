namespace StudentGroups.Models
{
    class Group
    {
        public Group(int number, string name)
        {
            this.GroupNumber = number;
            this.DepartmentName = name;
        }

        public int GroupNumber { get; set; }
        
        public string DepartmentName { get; set; }
    }
}