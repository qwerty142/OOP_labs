namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public interface ICommand
{
    public string Run(IContext currentFile);
}