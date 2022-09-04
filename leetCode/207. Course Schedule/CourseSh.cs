namespace ConsoleApp1.leetCode._207._Course_Schedule;

public class CourseSh
{
   
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        int[][] matrix = new int[][numCourses]; // i -> j
        for (int i = 0; i < numCourses; i++)
        {
            matrix[i] = new int[numCourses];
        }
        int[] indegree = new int[numCourses];
    
        for (int i=0; i<prerequisites.Length; i++) {
            int ready = prerequisites[i][0];
            int pre = prerequisites[i][1];
            if (matrix[pre][ready] == 0)
                indegree[ready]++; //duplicate case
            matrix[pre][ready] = 1;
        }
        
        int count = 0;
        Queue<int> queue = new Queue<int>();
        for (int i=0; i<indegree.Length; i++) {
            if (indegree[i] == 0) queue.Enqueue(i);
        }
        while (queue.Count>0) {
            int course = queue.Dequeue();
            count++;
            for (int i=0; i<numCourses; i++) {
                if (matrix[course][i] != 0) {
                    if (--indegree[i] == 0)
                        queue.Enqueue(i);
                }
            }
        }
        return count == numCourses;
        
    }
    
}