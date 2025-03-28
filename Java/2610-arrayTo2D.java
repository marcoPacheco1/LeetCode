import java.util.*;

class Solution {
    public List<List<Integer>> findMatrix(int[] nums) {
        List<List<Integer>> lists = new ArrayList<List<Integer>>();
        lists.add(new ArrayList<Integer>());
        Boolean added = false; 
        for (int i=0; i<nums.length; i ++)
        {
            for (List<Integer> list : lists) {
                if (!list.contains(nums[i]) && !added)
                {
                    list.add(nums[i]);
                    added = true;
                }
            }
            if (!added)
            {
                ArrayList<Integer> temp = new ArrayList<Integer>();
                temp.add(nums[i]);
                
                lists.add(temp);
            }  
            added = false;
        }
        return lists;
    }
}