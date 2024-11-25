using System.ComponentModel;

public class Todo
{
    [Description("The ID of the todo item.")]
    public int Id { get; set; }
    [Description("The name of the todo item.")]
    public string? Name { get; set; }
    [Description("Whether the todo item is complete.")]
    public bool IsComplete { get; set; }
}
