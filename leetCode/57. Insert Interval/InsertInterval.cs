namespace ConsoleApp1.leetCode._57._Insert_Interval;

public class InsertInterval
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var insertInterval = new int[2];
        var startInterval = 0;
        var endInterval = -1;
        if (intervals.GetLength(0) == 0)
        {
            return new int[][] {newInterval};
        }
        var list = new List<int[]>();
        for (int i = 0; i < intervals.GetLength(0); i++)
        {
            if (intervals[i][1] < newInterval[0]) list.Add(intervals[i]);
            if (intervals[i][0] > newInterval[0])
            {
                startInterval = i;
                insertInterval[0] = newInterval[0];
                break;
            }
            if (newInterval[0] >= intervals[i][0] && newInterval[0] <= intervals[i][1])
            {
                if (intervals[i][1] == newInterval[0]) insertInterval[0] = intervals[i][1];
                else insertInterval[0] = intervals[i][0];
                startInterval = i++;
                break;
            }
        }

        for (int j = startInterval; j < intervals.GetLength(0); j++)
        {
            
            if (intervals[j][0] > newInterval[1])
            {
                insertInterval[1] = newInterval[1];
                endInterval = j;
                break;
            }
            if (newInterval[1] >= intervals[j][0] && newInterval[1] <= intervals[j][1])
            {
                insertInterval[1] = intervals[j][1];
                endInterval = j++;
                break;
            }
        }

        if (endInterval == -1)
        {
            insertInterval[1] = newInterval[1];
            list.Add(insertInterval);
            return list.ToArray();
        }

        list.Add(insertInterval);
        for (int i = endInterval; i < intervals.GetLength(0); i++)
        {
            list.Add(intervals[i]);
        }

        return list.ToArray();

    }
    
}