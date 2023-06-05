namespace MasterClass.Assets.Scenes.Scripts.Patrones.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}