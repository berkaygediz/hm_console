import * as readline from "readline";

const calcu = "-calcu(int)";
const help = "-help(string)";

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
});

console.log("****HM Console***");
function start() {
  console.log(`Commands: ${calcu} , ${help}`);

  rl.question("Enter a command: ", (command) => {
    if (command === calcu) {
      console.log("**Calculator**");
      const plus = "-hm plus";
      const minus = "-hm minus";
      const multi = "-hm multiplication";
      const division = "-hm division";
      const modulus = "-hm modulus";

      console.log(
        `Commands: ${plus} , ${minus} , ${multi} , ${division} , ${modulus}`
      );

      rl.question("Enter a sub-command: ", (cmd) => {
        if (cmd === plus) {
          console.log("**ADDITION**");
          rl.question("Enter the first number: ", (xStr) => {
            const x = parseInt(xStr, 10);
            rl.question("Enter the second number: ", (yStr) => {
              const y = parseInt(yStr, 10);

              const sum = x + y;
              console.log(`Result: ${sum}`);
              start();
            });
          });
        } else if (cmd === minus) {
          console.log("**MINUS**");
          rl.question("Enter the first number: ", (xStr) => {
            const x = parseInt(xStr, 10);

            rl.question("Enter the second number: ", (yStr) => {
              const y = parseInt(yStr, 10);
              const sum = x - y;
              console.log(`Result: ${sum}`);
              start();
            });
          });
        } else if (cmd === multi) {
          console.log("**MULTIPLICATION**");
          rl.question("Enter the first number: ", (xStr) => {
            const x = parseInt(xStr, 10);
            rl.question("Enter the second number: ", (yStr) => {
              const y = parseInt(yStr, 10);
              const sum = x * y;
              console.log(`Result: ${sum}`);
              start();
            });
          });
        } else if (cmd === division) {
          console.log("**DIVISION**");
          rl.question("Enter the first number: ", (xStr) => {
            const x = parseInt(xStr, 10);

            rl.question("Enter the second number: ", (yStr) => {
              const y = parseInt(yStr, 10);
              const sum = x / y;
              console.log(`Result: ${sum}`);
              start();
            });
          });
        } else if (cmd === modulus) {
          console.log("**MODULUS**");
          rl.question("Enter the first number: ", (xStr) => {
            const x = parseInt(xStr, 10);

            rl.question("Enter the second number: ", (yStr) => {
              const y = parseInt(yStr, 10);
              const sum = x % y;
              console.log(`Result: ${sum}`);
              start();
            });
          });
        } else {
          console.log("Invalid sub-command. Please try again.");
          start();
        }
      });
    } else if (command === help) {
      console.log("**HELP**");
      console.log(`Commands: ${calcu} , ${help}\n-----------------`);
      start();
    } else {
      console.log("Invalid command. Please try again.");
      start();
    }
  });
}

start();
