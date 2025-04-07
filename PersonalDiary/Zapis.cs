namespace PersonalDiary;

public class Zapis
{
    public Zapis()
    {
        ToDoList = new List<ToDo>();
    }

    public Zapis(string pocutje, DateTime cas, string tekst)
    {
        Pocutje = pocutje;
        Cas = cas;
        Tekst = tekst;
        ToDoList = new List<ToDo>();
    }
    public string Pocutje { get; set; }
    public DateTime Cas { get; set; }
    public List<ToDo> ToDoList { get; set; }
    public string Tekst { get; set; }

    public override string ToString()
    {
        string seznamToDo = "";
        foreach (var el in ToDoList)
        {
            seznamToDo += el.ToString() + "\n";
        }
        return $"Cas: {Cas}\nPočutje: {Pocutje}\nToDo:\n{seznamToDo}Tekst: {Tekst}";
    }
    
}
   
public class ToDo
{
    public ToDo(){}

    public ToDo(bool narejeno, string tekst)
    {
        Narejeno = narejeno;
        Tekst = tekst;
    }
    
    public bool Narejeno { get; set; }
    public string Tekst { get; set; }
    
    public override string ToString()
    {
        
        string znak = Narejeno?"[X]":"[]";
        
        return $"{znak} - {Tekst}\n";
    }
}