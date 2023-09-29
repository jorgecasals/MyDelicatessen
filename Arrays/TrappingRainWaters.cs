using MyDelicatessen.Stacks;

namespace MyDelicatessen.ArrayProblems
{
    public class TrappingRainWaterProblem
    {
        public class Floor
        {
            public int height;
            public int width;
        }

        public int Trap(int[] height)
        {
            Stack<Floor> floors = new Stack<Floor>();
            int result = 0;

            foreach (var h in height)
            {
                if (floors.Length == 0)
                {
                    floors.Push(new Floor { height = h, width = 1 });
                    continue;
                }

                int temporal = 0;
                int width = 0;
                while (true)
                {
                    var floor = floors.Peek();
                    if (floor.height == h)
                    {
                        floor.width += width + 1;
                        result += temporal;
                        break;
                    }
                    else if (floor.height > h)
                    {
                        floors.Push(new Floor() { height = h, width = width + 1 });
                        result += temporal;
                        break;
                    }
                    else
                    {

                        temporal += ((h - floor.height) * floor.width);
                        width += floor.width;
                        floors.Pop();
                        if (floors.Length == 0)
                        {
                            floors.Push(new Floor() { height = h, width = 1 });
                            temporal -= (h - floor.height) * width;
                            result += temporal;
                            break;
                        }
                    }
                }
            }

            return result;
        }

        public int TrapSimplified(int[] height)
        {
            int ans = 0, current = 0;
            Stack<int> st = new Stack<int>();
            while (current < height.Length)
            {
                while (st.Count > 0 && height[current] > height[st.Peek()])
                {
                    int top = st.Pop();

                    if (st.Count == 0)//we break because we need two (always safe the element in the stack.)
                        break;
                    int distance = current - st.Peek() - 1;//We calculate the distance because we can be using a past step (more than one distance)
                    int bounded_height = min(height[current], height[st.Peek()]) - height[top]; //The two extremes decides the height of the water (minus top)
                    ans += distance * bounded_height;
                }
                st.Push(current++);
            }
            return ans;
        }
    }
}