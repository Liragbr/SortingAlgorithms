# Sorting Algorithms in C#

This project demonstrates the implementation of three popular sorting algorithms in C#: **Merge Sort**, **Bubble Sort**, and **Selection Sort**. The code is written in a simple and easy-to-understand manner, making it a great reference for learning about these algorithms.

## Table of Contents
- [Overview](#overview)
- [Algorithms Implemented](#algorithms-implemented)
- [Merge Sort](#merge-sort)
- [Bubble Sort](#bubble-sort)
- [Selection Sort](#selection-sort)
- [Example Output](#example-output)

## Overview

Sorting is a fundamental operation in computer science, used to arrange elements in a list in a certain order, typically in ascending or descending order. This project provides a basic implementation of three common sorting algorithms, allowing you to see how they work and compare their performance.

## Algorithms Implemented

### Merge Sort
Merge Sort is a **divide-and-conquer** algorithm that:
1. Divides the input array into two halves.
2. Recursively sorts both halves.
3. Merges the two sorted halves to produce the final sorted array.

### Bubble Sort
Bubble Sort is a simple comparison-based algorithm that:
1. Repeatedly steps through the list.
2. Compares adjacent elements and swaps them if they are in the wrong order.
3. Continues this process until the list is sorted.

### Selection Sort
Selection Sort is an algorithm that:
1. Divides the array into a sorted and an unsorted region.
2. Selects the smallest element from the unsorted region and swaps it with the first element of the unsorted region.
3. Moves the boundary between sorted and unsorted regions one element to the right.


## Example Output

When you run the program, you will see output similar to the following:

```plaintext
Vetor original para Merge Sort:
38 27 43 3 9 82 10 
Vetor ordenado com Merge Sort:
3 9 10 27 38 43 82 
Vetor original para Bubble Sort:
38 27 43 3 9 82 10 
Vetor ordenado com Bubble Sort:
3 9 10 27 38 43 82 
Vetor original para Selection Sort:
38 27 43 3 9 82 10 
Vetor ordenado com Selection Sort:
3 9 10 27 38 43 82 
