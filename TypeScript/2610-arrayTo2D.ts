function findMatrix(nums: number[]): number[][] {
    let matrix: number[][]=[];
    let found: boolean = false; 
    let added: boolean = false; 
    let newRow: number[] = [];
    matrix.push(newRow);
    for (let index = 0; index < nums.length; index++) {
        added =false;
        for (let row = 0; row < matrix.length; row++) {
            // for (let column = 0; column < matrix[0].length; column++) {
            let column =0;
            found = false;
            while (column < matrix[row].length && !found){    
                if (matrix[row][column] === nums[index]){
                    found = true;
                }
                column++;
            }
            if (!found && !added){
                matrix[row].push(nums[index]);
                added =true;
            }            
        }
        if (!added){
            let newRow: number[] = [];
            newRow.push(nums[index]);
            matrix.push(newRow);
        }        
    }
    return matrix;
}