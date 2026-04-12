function Autotest() {
  // 1
  document.querySelector("#task1 input").value = JSON.stringify([
    { name: "Alice", email: "alice@mail.com" },
    { name: "Bob", email: "bobmail.com" },
    null,
    { name: "Charlie", email: "charlie@mail.com" },
  ]);

  Task1();

  // 2
  Task2variables.forEach((e) => e.remove());
  Task2variables = [];
  Task2AddInput("Hello");
  Task2AddInput("World!");
  Task2();

  // 3
  document.querySelector("#task3 input").value = JSON.stringify({
    id: 1,
    particle: 10,
  });
  Task3();
}
