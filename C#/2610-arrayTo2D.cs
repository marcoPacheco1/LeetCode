// You are given an integer array nums. You need to create a 2D array from nums satisfying the following conditions:

// The 2D array should contain only the elements of the array nums.
// Each row in the 2D array contains distinct integers.
// The number of rows in the 2D array should be minimal.
// Return the resulting array. If there are multiple answers, return any of them.

// Note that the 2D array can have a different number of elements on each row.

public class Solution2610 {
    public IList<IList<int>> FindMatrix(int[] nums) {
        IList<IList<int>> lists = new List<IList<int>>(){new List<int>()};
        Boolean added = false; 
        for (int i=0; i<nums.Length; i ++)
        {
            foreach (List<int> list in lists){
                if (!list.Contains(nums[i]) && !added)
                {
                    list.Add(nums[i]);
                    added = true;
                }
            }
            if (!added)
            {
                lists.Add(new List<int>(){nums[i]});
            }  
            added = false;
        }
        return lists;
    }
}