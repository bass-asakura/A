namespace lesson4_12;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------------------------------------------");
        int[] x = {1, 4, 25, 12, 2, 5, 1, 2, 1, 2};
        int n = 3;
        int max_sum = 0;
        for (int i = 0; i < x.Length; i++){
            int[] a = x.Skip(i).Take(n).ToArray();
            if (a.Sum() > max_sum){
                max_sum = a.Sum();
            }
            else{
                Console.WriteLine("Подмассив с максимальной суммой - " + string.Join(", ", a));
                break;
            }
        }
        Console.WriteLine("-------------------------------------------------");

        int[] b = {1, 5, 2, 7, 12, 3, 3, 3, 3, 3};
        Array.Sort(b);
        Console.WriteLine("Отсортированный массив - " + string.Join(", ", b));
        int[] uniq = b.Distinct().ToArray();
        Console.WriteLine("Колличество уникальных элементов - " + uniq.Count());
        Console.WriteLine("-------------------------------------------------");
        
        int[] c = {1, 2, 1, 2, 1, 3, 4};
        int[] c_uniq = c.Distinct().ToArray();
        for (int i = 0; i < c_uniq.Length; i++){
            int povt_cnt = 0;
            for (int j = 0; j < c.Length; j++){
                if (c_uniq[i] == c[j]){
                    povt_cnt++;
                }
            }
            if (povt_cnt > 1){
                Console.WriteLine($"Элемент - {c[i]} Встречается {povt_cnt} раз(a)");
            }
        }
        Console.WriteLine("-------------------------------------------------");
    }
}
