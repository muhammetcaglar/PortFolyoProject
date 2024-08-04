namespace PortFolyoProject.DAL.Entities
{
    public class ToDoList
    {
        public int ToDolistId { get; set; }
        public String Title { get; set; }
        public String ImageUrl{ get; set; }
        public DateTime Date{ get; set; }
        public bool Status{ get; set; }
    }
}
