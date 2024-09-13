# 🌱 Genesis.Package.Template

This repository serves as a template for building and publishing .NET projects to NuGet.

## 🚀 Features

- **NuGet Publishing**: Publishes NuGet packages upon tagging with version numbers start with `v`.

## 🛠️ GitHub Actions Pipeline

This template includes a GitHub Actions workflow that automates the build and packaging process for your project.

### Workflow Details:

- **Trigger**: Automatically runs when a tag starting with `v` is pushed to the repository.
- **Steps**:
  - Checkout repository code.
  - Setup .NET environment.
  - Extract version from the tag.
  - Build the project.
  - Pack the NuGet package.
  - Publish the package to GitHub NuGet.

## 🛠️ Usage

 - Create a release tag (`vX.X.X`) to trigger the pipeline.

## 📝 License

This project is licensed under the MIT License. See the `LICENSE` file for more information.
