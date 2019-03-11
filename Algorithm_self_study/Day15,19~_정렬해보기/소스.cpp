#include <iostream>

int sorted[1000000];
void MergeSort(int *arr, int, int);
void Merge(int*, int, int, int);

int main() {
	int input;
	scanf("%d", &input);
	int *arr = new int[input];
	for (int i = 0; i < input; i++) 
		scanf("%d", &arr[i]);

	MergeSort(arr, 0,input-1);
	
	for (int i = 0; i < input; i++)
		printf("%d\n", arr[i]);
}

void MergeSort(int *arr, int Left, int Right) {
	if (Left < Right) {
		int Mid = (Right + Left) / 2;
		MergeSort(arr, Left, Mid);
		MergeSort(arr, Mid + 1, Right);
		Merge(arr, Left, Mid, Right);
	}
}

void Merge(int *arr, int Left, int Mid, int Right) {
	int first = Left;
	int second = Mid + 1;
	int order = Left;

	while (first <= Mid && second <= Right) {
		if (arr[first] <= arr[second]) 
			sorted[order++] = arr[first++];
		else
			sorted[order++] = arr[second++];
	}

	if (first > Mid)
		for (int i = second; i <= Right; i++)
			sorted[order++] = arr[i];
	else
		for (int i = first; i <= Mid; i++)
			sorted[order++] = arr[i];

	for (int i = Left; i <= Right; i++) 
		arr[i] = sorted[i];
}