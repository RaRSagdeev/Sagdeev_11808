using System;
using System.Collections.Generic;


//Для работы Алгоритма А Стар необдходим взвешенный граф
public interface WeighteGraph<L>
{
    double Cost(Location a, Location b);
    IEnumerable<Location> Neighbors(Location id);
}

//локация,координаты
public class Location
{
    public readonly int x, y;
    public Location(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}


//очередь,организованная на List
public class PriorityQueue<T>
{
    private List<Tuple<T, double>> elements = new List<Tuple<T, double>>();

    public int Count
    {
        get { return elements.Count; }
    }

    public void Enqueue(T item, double priority)
    {
        elements.Add(Tuple.Create(item, priority));
    }

    public T Dequeue()
    {
        //изначально наиболее подходящий элемент нулевой
        int bestIndex = 0;
        //проходим по всему массиву и ищем наиболее подходящий элемент
        //(индекс этого элемента)
        for (int i = 0; i < elements.Count; i++)
        {
            if (elements[i].Item2 < elements[bestIndex].Item2)
            {
                bestIndex = i;
            }
        }
        //забираем подходящий элемент и удаляем его
        T bestItem = elements[bestIndex].Item1;
        elements.RemoveAt(bestIndex);
        return bestItem;
    }
}

public class AStarSearch
{
    public Dictionary<Location, Location> cameFrom
        = new Dictionary<Location, Location>();
    public Dictionary<Location, double> costSoFar
        = new Dictionary<Location, double>();

    //Алгоритм А Стар является слиянием двух алгоритмов: Жадного алгоритма и 
    //алгоритма Дейкстры. Отличие же Алгоритма А Стар от жадного в том,что он
    //использует эвристику лишь для увеличения вероятности более раннего нахождения
    //кратчайшего пути. Алгоритм Дейкстры же вообще не использует эвристику,чем
    //сильно замедляет работу в среднем.
    static public double Heuristic(Location a, Location b)
    {
        return Math.Abs(a.x - b.x) + Math.Abs(a.y - b.y);
    }
    //основной алогритм
    public AStarSearch(WeighteGraph<Location> graph, Location start, Location goal)
    {
        //наша граница, которая расширяется при поиске пути
        //как и в Алгоритме Дейкстры и поиске в ширину
        var frontier = new PriorityQueue<Location>();
        frontier.Enqueue(start, 0);
        //точка отбытия
        cameFrom[start] = start;
        //cost so far из Алгоритма Дейкстры(трудность прохода)
        costSoFar[start] = 0;

        while (frontier.Count > 0)
        {
            var current = frontier.Dequeue();

            if (current.Equals(goal))
            {
                break;
            }

            foreach (var next in graph.Neighbors(current))
            {
                //новая сложность прохода = старая +
                //сложность прохода от текущей до следующей точки
                double newCost = costSoFar[current]
                    + graph.Cost(current, next);
                //если в уже вычисленной сложности отсутствует следующая точка графа
                //или же новая сложность меньше вычисленной для следующей
                //то мы продолжаем движение в данном направлении
                if (!costSoFar.ContainsKey(next)
                    || newCost < costSoFar[next])
                {
                    costSoFar[next] = newCost;
                    //вычисление приоритета, нужно для ускорения поиска
                    //отсутствует в Алгоритме Дейкстры
                    double priority = newCost + Heuristic(next, goal);
                    frontier.Enqueue(next, priority);
                    cameFrom[next] = current;
                }
            }
        }
    }
}
