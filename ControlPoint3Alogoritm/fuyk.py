import time
import random
import sys

sys.setrecursionlimit(1000000)


# --- Bubble Sort (оптимизированный) ---
def bubble_sort(arr):
    n = len(arr)
    for i in range(n):
        swapped = False
        for j in range(n - i - 1):
            if arr[j] > arr[j + 1]:
                arr[j], arr[j + 1] = arr[j + 1], arr[j]
                swapped = True
        if not swapped:
            break
    return arr


# --- Merge Sort ---
def merge_sort(arr):
    if len(arr) <= 1:
        return arr
    mid = len(arr) // 2
    left = merge_sort(arr[:mid])
    right = merge_sort(arr[mid:])
    return merge(left, right)


def merge(left, right):
    result = []
    i = j = 0
    while i < len(left) and j < len(right):
        if left[i] <= right[j]:
            result.append(left[i])
            i += 1
        else:
            result.append(right[j])
            j += 1
    result.extend(left[i:])
    result.extend(right[j:])
    return result


# --- Генераторы тестовых данных ---
def best_case_bubble(n):
    return list(range(n))  # уже отсортирован


def average_case(n):
    arr = list(range(n))
    random.shuffle(arr)
    return arr


def worst_case_bubble(n):
    return list(range(n - 1, -1, -1))  # обратный порядок


def best_case_merge(n):
    # Левая половина содержит все меньшие элементы, правая — все бóльшие
    half = n // 2
    return list(range(half)) + list(range(half, n))


def worst_case_merge(n):
    # Максимальное чередование: чётные индексы в одной половине, нечётные в другой
    arr = [0] * n
    for i in range(n):
        if i % 2 == 0:
            arr[i] = i // 2
        else:
            arr[i] = n // 2 + i // 2
    return arr


# --- Функция замера ---
def measure(sort_func, data_generator, n, repeats=5):
    total = 0.0
    for _ in range(repeats):
        arr = data_generator(n)
        start = time.perf_counter()
        sort_func(arr)
        total += time.perf_counter() - start
    return total / repeats


# --- Основной цикл тестирования ---
sizes_small = [10, 100, 1000]
sizes_large_bubble = [5000, 10000]
sizes_large_merge = [50000, 100000]

print("=== Bubble Sort ===")
for n in sizes_small + sizes_large_bubble:
    t_best = measure(bubble_sort, best_case_bubble, n)
    t_avg = measure(bubble_sort, average_case, n)
    t_worst = measure(bubble_sort, worst_case_bubble, n)
    print(
        f"n={n:>6} | best: {t_best:.6f} s | avg: {t_avg:.6f} s | worst: {t_worst:.6f} s"
    )

print("\n=== Merge Sort ===")
for n in sizes_small + sizes_large_merge:
    t_best = measure(merge_sort, best_case_merge, n)
    t_avg = measure(merge_sort, average_case, n)
    t_worst = measure(merge_sort, worst_case_merge, n)
    print(
        f"n={n:>6} | best: {t_best:.6f} s | avg: {t_avg:.6f} s | worst: {t_worst:.6f} s"
    )
