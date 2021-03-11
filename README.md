# Birthday-Paradox
BIRTHDAY PARADOX EXPERIMENTS using C#

1.1) Birthday Paradox experiments
The birthday paradox says that the probability that two people in a room will have the same birthday is more than half, provided n, the number of people in the room, is more than 23. This property is not really a paradox, but many people find it surprising.
(from Goodrich and Tamassia)
Example Applet : http://www-stat.stanford.edu/~susan/surprise/Birthday.html
Demo: http://demonstrations.wolfram.com/SimulatingTheBirthdayProblem/

Consider a version of this problem for those born on the same day of the week. For example; Let there be two people, one born on 02.03.1994 (Wednesday) and the other born on 09.06.1993 (Wednesday). In this version of the problem it will be taken into account that these two people were born on the same day of the week (although they have different birth dates).

Program that can test this paradox by a series of experiments on randomly generated birthdays, which test this paradox for n = 2, 3, 5, 10, 20 people in room.

Conflict: There is 1 overlap if the birth date of 2 people is on the same day of the week. For this, it is enough to have the same name of the day born. The birth year, month, and day number need not be equal. If 3 people were born on the same day, there are 2 overlaps. There are 6 conflicts if 7 people have the same birthday.

Program include the following two listings:
i) By making simulations, only statistical values (collision numbers) for 15 experiments can be displayed as a separate 16 x 5 table. 5 columns for different values of n (n = 2, 3, 5, 10, 20 people), 15 rows for the average number of overlaps in each experiment and 16th row for the average of these 15 values are printed.

Conflicts in individual trials should be demonstrated. The number of overlaps on the days of the week shown in a 7-element array should be printed for each trial. This process is repeated 15 times for each value of n. Then, a 16x5 summary list in i) should also be given.

15 attempts will be made from scratch. In other words, for 10 people, 150 birth dates should not be overlapped. As you know from statistics, conflicts will be reset for every 10 people and a new experiment will be done. The average of 15 experiments will give a more realistic value.
