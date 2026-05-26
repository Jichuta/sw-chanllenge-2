# SW Challenge 2: TDD with a Simple Domain

| Level | Skills | Required Resources | Time |
| --- | --- | --- | --- |
| Fundamentals | - Test-Driven Development (TDD)<br>- unit testing<br>- red-green-refactor cycle<br>- code coverage<br>- assertion libraries. | - Any language with a test runner (pytest, Jest, JUnit, xUnit)<br>- GitHub<br>- coverage tool (coverage.py, Istanbul, JaCoCo). | 1 - 2 days |

**Challenge: Roman number converter with TDD**

A library that converts integers to Roman numerals and back. The rules are well-defined, incremental, and full of edge cases (4, 9, 40, 90, 400, 900) that naturally drive new tests before new code.

This challenge is about building the discipline of Test-Driven Development from scratch. The goal is not to deliver a complex application, it is to internalize the red-green-refactor rhythm until it becomes muscle memory. You will build a small, self-contained Python (or JavaScript/Java/.NET) library to solve one well-scoped problem, and you will do it by writing every single test before the code it validates.

These are the constraints that make this a TDD exercise rather than just a "project with tests":

- No production code without a red test. Before you write or change any function in your library, there must be a failing test that is asking for that behavior. If you open your library file and start typing logic that no test is currently demanding, stop. Write the test first.
- Commit after every red-green-refactor cycle. Each cycle produces three commits (or at minimum one commit per phase if you prefer to combine red+green): a commit where the new test exists and fails, a commit where the test passes with the simplest possible code, and a commit after any refactor. Your Git log is the proof of your process.
- The simplest code that makes the test pass. In the green phase, resist the urge to write the "smart" implementation. Write the dumbest thing that works. Generalization and cleanup happen in the refactor phase, driven by the next test.
- Refactor at least twice, visibly. You must perform at least two meaningful refactors during the exercise, not just renaming a variable, but restructuring: extracting a method, removing duplication across cases, introducing a value object, or reorganizing the module layout. Each refactor must happen while all tests are green, and must be committed separately.
- 90% or higher line coverage at the end. Run your coverage tool before submitting. If you are below 90%, the missing lines are telling you there is behavior you have not specified with a test yet. Add the tests.

**Deliverables**

A repository containing at least the following:

- library code
- test code
- rules of the chosen domain (documented in a README).
- README with explanation how to run tests and coverage.
- Final coverage report
