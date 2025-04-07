using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FileUtils;



/* 
    For example:

    3   4
    4   3
    2   5
    1   3
    3   9
    3   3


*/

/*

pair up the numbers and measure how far apart they are

Pair up the smallest number in the left list with the smallest number in the right list

Pair up the smallest number in the left list with the smallest number in the right list

Within each pair, figure out how far apart the two numbers are; you'll need to add up all of those distances

To find the total distance between the left list and the right list, add up the distances between all of the pairs you found

*/

string filePath = @"/Users/marcmoxey/Repo/advent-of-code/01Day/HistorianHysteria/input.txt";


// split in left and right side into a list 
try {

    var (left, right) = FileUtils.FileUtils.SplitFileIntoTwoLists(filePath);

    List<int> distances = new List<int>();

// Repeat the process until both lists are empty
while (left.Count > 0 && right.Count > 0)
{
    // Get the minimum value from the left list
    int minLeft = left.Min();

    // Get the minimum value from the right list
    int minRight = right.Min();

    // Calculate the distance between the two minimum values
    int distance = Math.Abs(minLeft - minRight);
    distances.Add(distance);

    // Remove the minimum values from the lists
    left.Remove(minLeft);
    right.Remove(minRight);
}

// Calculate the total distance
int totalDistance = distances.Sum();
Console.WriteLine($"Total Distance: {totalDistance}");


} catch (Exception ex) {
    Console.WriteLine($"Error: {ex.Message}");
    return;
}







Console.ReadLine();
