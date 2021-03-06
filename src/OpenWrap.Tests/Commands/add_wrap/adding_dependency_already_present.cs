﻿using NUnit.Framework;
using OpenWrap.Commands.contexts;
using OpenWrap.Commands.Wrap;

namespace OpenWrap.Tests.Commands
{
    class adding_dependency_already_present : command_context<AddWrapCommand>
    {
        public adding_dependency_already_present()
        {
            given_dependency("depends: sauron >= 2.0");
            given_project_package("sauron", "1.0.0");
            given_system_package("sauron", "2.0.0");

            when_executing_command("sauron");
        }
        [Test]
        public void package_is_updated()
        {
            Environment.ProjectRepository.ShouldHavePackage("sauron", "2.0.0");
        }
    }
}