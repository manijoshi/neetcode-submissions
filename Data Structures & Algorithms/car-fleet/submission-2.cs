public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        Stack<float> fleet = new Stack<float>();
        var cars = new(int position, int speed)[position.Length];
    
        int s = 0;
        for(int i=0;i<position.Length;i++){
            cars[i] = (position[i],speed[i]);
        }
        Array.Sort(cars,(a,b)=>b.position.CompareTo(a.position));
    //7,4,1,0
        for(int i=0;i<cars.Length;i++){
            float currentTime = (float)(target-cars[i].position)/cars[i].speed;
            if(fleet.Count==0){
                fleet.Push(currentTime);
                s++;
            }
            else if(fleet.Peek()<currentTime){
                fleet.Push(currentTime);
                s++;
            }
        }
        return s;
    }
}
