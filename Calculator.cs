public class matrix {
    public static void main(String[] args) {
    
    //Creating Matrix
    int a[][] = {{1,2,3},{4,5,6},{1,2,3}};
    int b[][] = {{4,5,6},{1,2,3},{4,5,6}};
    int result[][] = new int[3][3];
    int result1[][] = new int[3][3];
    for(int i=0; i<3; i++){
        for(int j=0; j<3; j++){
            result[i][j] = a[i][j] + b[i][j];
            result1[i][j] = a[i][j] * b[i][j];
            System.out.print(result[i][j] + " ");
            System.out.print("   " +result1[i][j] + " ");
        }
        System.out.println(" ");
    }
}
    
}
