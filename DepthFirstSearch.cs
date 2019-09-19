namespace Data_Structures___Algorithms
{
    public class DepthFirstSearch
    {
        private int _Color;
        private int _NewColor;

        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            _Color = image[sr][sc];
            _NewColor = newColor;
            dfsFoodFill(sr, sc, image);
            return image;
        }

        // perform depth first search and flood fill all row and column in 4 directions
        private void dfsFoodFill(int row, int col, int[][] image)
        {
            if (image[row][col] == _Color)
            {
                image[row][col] = _NewColor;
                if (row > 0) dfsFoodFill(row - 1, col, image);
                if (col > 0) dfsFoodFill(row, col - 1, image);
                if (row < image.Length - 1) dfsFoodFill(row + 1, col, image);
                if (col < image[row].Length - 1) dfsFoodFill(row, col + 1, image);
            }
        }
    }
}