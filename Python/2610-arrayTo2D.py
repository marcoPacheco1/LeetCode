from typing import List
class Solution:
    def findMatrix(self, nums: List[int]) -> List[List[int]]:
        lists = [[]]
        added = False; 
        for num in nums:
            for list in lists:
                if (not num in list and not added):
                    list.append(num)
                    added = True
            if (not added):
                list = [num]
                lists.append(list)
            added = False
        return lists

mi_instancia = Solution()
mi_lista_de_numeros = [1,3,4,1,2,3,1]
resultado = mi_instancia.findMatrix(mi_lista_de_numeros)