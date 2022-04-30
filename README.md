# F Sharp [Fable](https://fable.io/) [Sutil](https://davedawkins.github.io/Sutil/) Starter featuring [Vite](https://vitejs.dev/) for faster builds and [Tailwind](https://tailwindcss.com/) styles.

This is a small Fable app project so you can easily get started and add your own code progressively. For more comprehensive templates [check this page](https://fable.io/docs/2-steps/your-first-fable-project.html).

## Requirements

* [dotnet SDK](https://www.microsoft.com/net/download/core) 5.0 or higher
* [node.js](https://nodejs.org)
* An F# editor like Visual Studio, Visual Studio Code with [Ionide](http://ionide.io/) or [JetBrains Rider](https://www.jetbrains.com/rider/)

## Building and running the app

* Install dependencies: `yarn install`
* Start the compiler in watch mode and a development server: `yarn start`
* After the first compilation is finished, in your browser open: http://localhost:3000/

Any modification you do to the F# code will be reflected in the web page after saving.

> Note: check the "scripts" section in `package.json` to see the commands triggered by the steps above.

## Bundling for release

Run the following command to compile and bundle up all your F# code into one Javascript file: `yarn run build`. The compiled output ends up in the `public` folder.

## Project structure

### npm

JS dependencies are declared in `package.json`, while `package-lock.json` is a lock file automatically generated.

### Vite

[Vite](https://vitejs.dev/) is a JS build tool and dev server built for perfomance with sensible defaults. Config is found in vite.config.js.

### F#

The sample only contains two F# files: the project (.fsproj) and a source file (.fs) in the `src` folder.

### Web assets

The `index.html` is in the root and vite automatically traces any dependencies referenced within the html tags. File and other assets like an icon can be found in the `public` folder.
