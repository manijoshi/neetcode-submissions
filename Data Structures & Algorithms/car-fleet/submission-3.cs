public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var cars = new(int position, int speed)[position.Length];
        double lastFleetTime = 0;
        int fleets = 0;
        for(int i=0;i<position.Length;i++){
            cars[i] = (position[i],speed[i]);
        }
        Array.Sort(cars,(a,b)=>b.position.CompareTo(a.position));
        for(int i=0;i<cars.Length;i++){
            double currentTime = (double)(target-cars[i].position)/cars[i].speed;

            if(lastFleetTime<currentTime){
                lastFleetTime=currentTime;
                fleets++;
            }
        }
        return fleets;
    }
}
