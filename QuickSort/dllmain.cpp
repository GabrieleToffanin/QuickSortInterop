#include "pch.h"

#include <functional>
#define DLLExport __declspec(dllexport)

BOOL APIENTRY DllMain(HMODULE hModule,
    DWORD  ul_reason_for_call,
    LPVOID lpReserved
)
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

int partition(int* arr, int start, int end)
{
    int index = 0, pivotElement = arr[end], pivotIndex;
    int* temp = new int[end - start + 1];
    for (int i = start; i <= end; i++)
    {
        if (arr[i] < pivotElement)
        {
            temp[index] = arr[i];
            index++;
        }
    }

    temp[index] = pivotElement;
    index++;

    for (int i = start; i < end; i++)
    {
        if (arr[i] > pivotElement)
        {
            temp[index] = arr[i];
            index++;
        }
    }



    index = 0;
    for (int i = start; i <= end; i++)
    {
        if (arr[i] == pivotElement)
        {
            pivotIndex = i;
        }
        arr[i] = temp[index];
        index++;
    }
    return pivotIndex;
}

extern "C" DLLExport void quickSort(int* arr, int start, int end)
{
    if (start < end)
    {
        int partitionIndex = partition(arr, start, end);
        quickSort(arr, start, partitionIndex - 1);
        quickSort(arr, partitionIndex + 1, end);
    }
    return;
}



