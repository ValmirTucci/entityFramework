namespace Blog.Models
{
    public class User //referencia a tabela
    {
        public int Id { get; set; } //referencia a coluna
        public String Name { get; set; }
        public String Email { get; set; }
        public String PasswordHash { get; set; }
        public String Image { get; set; }
        public String Slug { get; set; }
        public String Bio { get; set; }
    }
}