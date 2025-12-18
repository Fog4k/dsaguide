using Microsoft.AspNetCore.Mvc;

namespace DsaGuide.Controllers;

public class TopicsController : Controller
{
    public IActionResult Index() => Redirect("/Home/Index");

    public IActionResult Array() => View();
    public IActionResult SortingAlgorithms() => View();
    public IActionResult SearchingAlgorithms() => View();

    public IActionResult LinkedList() => View();
    public IActionResult DoublyLinkedList() => View();
    public IActionResult CircularLinkedList() => View();

    public IActionResult Recursion() => View();
    public IActionResult Tree() => View();
    public IActionResult BinaryTree() => View();
    public IActionResult BinarySearchTree() => View();

    public IActionResult TernaryTree() => View();
    public IActionResult TernarySearchTree() => View();

    public IActionResult Radix() => View();
    public IActionResult Heap() => View();

    public IActionResult Queue() => View();
    public IActionResult Stack() => View();

    public IActionResult Graph() => View();
    public IActionResult DirectedGraph() => View();
    public IActionResult UndirectedGraph() => View();
    public IActionResult WeightedGraph() => View();
    public IActionResult UnweightedGraph() => View();

    public IActionResult BellmanFord() => View();
    public IActionResult Dijkstra() => View();
    public IActionResult AStar() => View();
}