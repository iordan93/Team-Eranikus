using WorldOfASCIITanks.GameObjects;
using WorldOfASCIITanks.GameObjects.World.Movable;

namespace WorldOfASCIITanks.Interfaces
{
    internal interface IRenderer
    {
        void EnqueueForRendering(GameObject obj);

        void RenderAll(MainCharacter character);

        void RenderAllVisible(MainCharacter character);

        void ClearQueue();
    }
}