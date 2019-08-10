namespace Objective.Core.Domain.Objectives
{
    public interface IObjectiveFactory
    {
        Objective Create(string name, string description);
    }
}
