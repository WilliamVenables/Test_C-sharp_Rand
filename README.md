# Test_C-sharp_Rand
 This is a speed test on different ways of generating a random number from 1-100 using 4 different methods.
 1. Instantiate a new Random object each loop and use a range inside of Next
 2. Instantiate a new Random object each loop and use empty Next, mod 100 + 1
 3. Instantiate a new Random object once and use a range inside of Next
 4. Instantiate a new Random object once and use empty Next, mod 100 + 1

# Results
 | Method Number | Average across 50 loops |
 | ------------- | ----------------------- |
 | 1             | 4797                    |
 | 2             | 4716                    |
 | 3             | 107                     |
 | 4             | 94                      |

 Best option is to use a single instance of random, and to use mod and addition to get to the range you want.  Worst option is to create a new instance each time and to set a range in the Next() call.  Overrall, creating a new instance of random each iteration is far too slow to be practical.  This was just a fun experiment to see how much slower it was.
