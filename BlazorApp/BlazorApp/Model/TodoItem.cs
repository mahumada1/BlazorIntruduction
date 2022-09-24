namespace BlazorApp.Model
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public bool Finalizada { get; set; } = false;
    }
}
