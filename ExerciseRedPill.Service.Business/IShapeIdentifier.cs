using knockknock.readify.net;

namespace ExerciseRedPill.Service.Business
{
    public interface IShapeIdentifier
    {
        TriangleType IdentifyTriangleType(int a, int b, int c);
    }
}