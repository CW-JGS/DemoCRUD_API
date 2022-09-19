namespace api.models;

public partial class todo: IModel
{
    public Guid TodoID { get; init; }
    public Guid CreatorID { get; init; }
    public string todoHeading { get; set; }
    public string todoBody { get; set; }
    public todoStatus Status { get; set; }

    public todo(Guid _creatorID, string _todoHeading, string _todoBody)
    {
        TodoID = new Guid();
        CreatorID = _creatorID;
        todoHeading = _todoHeading;
        todoBody = _todoBody;
        Status = todoStatus.N;
    }
}