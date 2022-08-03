public class FoodRatings {
    
    class Food {
        public string Name { get; set; }
        public int Rating { get; set; }
    }
    
    class FoodComparer : IComparer<Food>{
        public int Compare(Food a, Food b){
            if(a.Rating != b.Rating)
                return a.Rating-b.Rating;
            else
                return string.Compare(b.Name, a.Name);
        }
    }    
    
    Dictionary<string, SortedSet<Food>> cusineFoodList = new Dictionary<string, SortedSet<Food>>();
    Dictionary<string, string> foodCusine = new Dictionary<string, string>();
    Dictionary<string, Food> foodnameFood = new Dictionary<string, Food>();

    public FoodRatings(string[] foods, string[] cuisines, int[] ratings) {
        for(int i = 0; i < foods.Length; i++){
            if(!cusineFoodList.ContainsKey(cuisines[i]))
                cusineFoodList.Add(cuisines[i], new SortedSet<Food>(new FoodComparer()));
            Food f = new Food() { Name = foods[i], Rating = ratings[i] };
            cusineFoodList[cuisines[i]].Add(f);
            foodnameFood.Add(foods[i], f);
            foodCusine.Add(foods[i], cuisines[i]);
        }
    }
    
    public void ChangeRating(string food, int newRating) {
        Food old = foodnameFood[food];
        Food f = new Food() { Name = food, Rating = newRating };
        cusineFoodList[foodCusine[food]].Remove(old);
        cusineFoodList[foodCusine[food]].Add(f);
        foodnameFood[food] = f;
    }
    
    public string HighestRated(string cuisine) {
        return cusineFoodList[cuisine].Max.Name;
    }
}