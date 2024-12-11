
namespace GEOMR
{
    public interface ISeries
    {
        int Next { get; }
        void Reset();
        void SetStart(int x);
    }
    // Класс геометрической прогрессии
    public class GeometricProgression : ISeries, IComparable<GeometricProgression>, ICloneable
    {
        public int Start { get; private set; }
        public int Step { get; private set; }
        private int current;

        // Конструктор
        public GeometricProgression(int start, int step)
        {
            Start = start;
            Step = step;
            Reset();
        }

        // Следующее число в прогрессии
        public int Next
        {
            get { return GetNext(); }
        }

        // Получение следующего числа
        public int GetNext()
        {
            current *= Step;
            return current;
        }

        // Сброс к начальному значению
        public void Reset()
        {
            current = Start;
        }

        // Установка начального значения
        public void SetStart(int x)
        {
            Start = x;
            Reset();
        }

        // Сравнение по шагу прогрессии
        public int CompareTo(GeometricProgression other)
        {
            return Step.CompareTo(other.Step);
        }

        // Клонирование
        public object Clone()
        {
            return new GeometricProgression(Start, Step);
        }
    }

}
