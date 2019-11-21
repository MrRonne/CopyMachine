namespace CopyMachine
{
    public interface ICopyMachine
    {
        IState State { get; set; }
        string SelectedDocument { get; set; }
        uint CopyCost { get; }
        uint Balance { get; set;  }
    }
}