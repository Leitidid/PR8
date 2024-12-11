
namespace GEOMR
{
    public interface ISeries
    {
        int Next { get; }
        void Reset();
        void SetStart(int x);
    }
    // ����� �������������� ����������
    public class GeometricProgression : ISeries, IComparable<GeometricProgression>, ICloneable
    {
        public int Start { get; private set; }
        public int Step { get; private set; }
        private int current;

        // �����������
        public GeometricProgression(int start, int step)
        {
            Start = start;
            Step = step;
            Reset();
        }

        // ��������� ����� � ����������
        public int Next
        {
            get { return GetNext(); }
        }

        // ��������� ���������� �����
        public int GetNext()
        {
            current *= Step;
            return current;
        }

        // ����� � ���������� ��������
        public void Reset()
        {
            current = Start;
        }

        // ��������� ���������� ��������
        public void SetStart(int x)
        {
            Start = x;
            Reset();
        }

        // ��������� �� ���� ����������
        public int CompareTo(GeometricProgression other)
        {
            return Step.CompareTo(other.Step);
        }

        // ������������
        public object Clone()
        {
            return new GeometricProgression(Start, Step);
        }
    }

}
