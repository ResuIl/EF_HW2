namespace EF_HW2.Models;

public class T_Cards
{
    public int Id { get; set; }
    public int Id_Teacher { get; set; }
    public int Id_Books { get; set; }
    public DateTime DateOut { get; set; }
    public DateTime DateIn { get; set; }
    public int Id_Lib { get; set; }
}
