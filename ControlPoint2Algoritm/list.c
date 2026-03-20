#include <stdarg.h>
#include <stddef.h>
#include <stdio.h>
#include <stdlib.h>
typedef struct node_t {
    struct node_t* next;
    int data;
} node_t;

typedef struct single_linked_list_t {
    node_t* head;
    node_t* tail;
} single_linked_list_t;

int insert(single_linked_list_t* list, int item)
{
    if (list == NULL)
        return -1;

    node_t* newNode = (node_t*)malloc(sizeof(node_t));
    if (newNode == NULL)
        return -2;

    newNode->data = item;
    newNode->next = list->head;

    list->head = newNode;
    if (list->tail == NULL) {
        list->tail = newNode;
    }

    return 0;
}

int append(single_linked_list_t* list, int item)
{
    if (list == NULL)
        return -1;

    if (list->tail == NULL) {
        return insert(list, item);
    }

    node_t* newNode = (node_t*)malloc(sizeof(node_t));
    if (newNode == NULL)
        return -2;
    newNode->data = item;
    newNode->next = NULL;

    list->tail->next = newNode;
    list->tail = newNode;
    return 0;
}

void iterate(single_linked_list_t list)
{
    node_t* current = list.head;

    fputs("[ ", stdout);

    while (current) {
        printf("%d ", current->data);
        current = current->next;
    }

    fputs("]\n", stdout);
    fflush(stdout);
}

node_t* find_item(single_linked_list_t list, int item)
{
    node_t* current = list.head;

    while (current) {
        if (current->data == item) {
            return current;
        }
        current = current->next;
    }

    return NULL;
}

int delete_item_after(single_linked_list_t* list, node_t* node)
{
    if (list == NULL || list->head == NULL)
        return -1;
    if (node == NULL) {
        list->head = list->head->next;
        free(list->head);
        return 0;
    };

    if (node->next == NULL)
        return -3;
    node_t* nodeToDelete = node->next;
    node->next = node->next->next;

    free(nodeToDelete);
    return 0;
}

int initialize_list(single_linked_list_t* list, int count, ...)
{
    list->head = list->tail = NULL;

    va_list number;
    va_start(number, count);
    for (int i = 0; i < count; ++i) {
        append(list, va_arg(number, int));
    }

    va_end(number);

    return 0;
}
