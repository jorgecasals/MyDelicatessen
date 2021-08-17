public class Solution {
    public void Rotate(int[][] matrix) {
        Rotate(matrix, 0, 0, matrix.Length);
    }
    
    public void Rotate(int[][] matrix, int initX, int initY, int length){
        if(length <= 1)
            return;
        
        for(int i = 0; i < length-1; i++){
            int initial = matrix[initX][initY + i];
            int next = matrix[initX + i][initY + length - 1];
            matrix[initX + i][initY + length - 1] = initial;
            
            initial = next;
            next = matrix[initX + length - 1][initY + length - 1 - i];
            matrix[initX + length - 1][initY + length - 1 - i] = initial;
            
            initial = next;
            next = matrix[initX + length - 1 - i][initY];
            matrix[initX + length - 1 - i][initY] = initial;
            
            matrix[initX][initY + i] = next;            
        }
        
        Rotate(matrix, initX+1, initY+1, length - 2);
    }
}