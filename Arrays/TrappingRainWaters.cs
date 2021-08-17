using MyDelicatessen.Stacks;

namespace MyDelicatessen.ArraySolutions
{
    public class TrappingRainWaterSolution
    {
        public int Trap(int[] height)
        {
            Stack<Floor> floors = new Stack<Floor>();
            int result = 0;

            foreach (var h in height)
            {
                if (floors.Count == 0)
                {
                    floors.Push(new Floor() { height = h, width = 1 });
                }
                else
                {
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
                            if (floors.Count == 0)
                            {
                                floors.Push(new Floor() { height = h, width = 1 });
                                temporal -= (h - floor.height) * width;
                                result += temporal;
                                break;
                            }
                        }
                    }
                }
            }

            return result;
        }

        public class Floor
        {
            public int height;
            public int width;
        }
    }
}