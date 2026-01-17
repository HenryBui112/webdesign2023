#include <stdio.h>

int main() {
    int a;
    int sum = 0;
    printf("Enter a postive integer a:");
    scanf("%d", &a);

    if (a <= 0) {
        printf("Please enter a positive integer.\n");
        return 0;
    }
    for (int i = 1; i<=a; i++) {
        sum += 1;
    }

    printf("Sum of integers from 1 to %d is: %d\n", a, sum);
    return 0;
}