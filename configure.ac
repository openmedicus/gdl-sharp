AC_INIT([gdl-sharp], [3.34.0])
AC_CONFIG_SRCDIR([README])
AC_CANONICAL_TARGET
AM_INIT_AUTOMAKE
AM_MAINTAINER_MODE
AC_PROG_INSTALL

dnl Package settings
ASSEMBLY_COMPANY="XMedicus Systems ApS"
ASSEMBLY_COPYRIGHT="2015, 2016, 2017, 2018, 2019, 2020 XMedicus ApS, Mikkel Kruse Johnsen"
ASSEMBLY_DESCRIPTION="Gdl-3 bindings for C#"
ASSEMBLY_NAME="gdl-sharp"
ASSEMBLY_NAMESPACE="Gdl"
ASSEMBLY_PC="gdl-sharp-3"
ASSEMBLY_SHORTNAME="gdl"
ASSEMBLY_TITLE="Gdl#"
ASSEMBLY_VERSION="3.2.0.0"
AC_SUBST([ACLOCAL_AMFLAGS], ["-I m4 \${ACLOCAL_FLAGS}"])

AC_SUBST(ASSEMBLY_NAME)
AC_SUBST(ASSEMBLY_VERSION)
AC_SUBST(ASSEMBLY_NAMESPACE)
AC_SUBST(ASSEMBLY_SHORTNAME)
AC_SUBST(ASSEMBLY_TITLE)
AC_SUBST(ASSEMBLY_DESCRIPTION)
AC_SUBST(ASSEMBLY_COMPANY)
AC_SUBST(ASSEMBLY_COPYRIGHT)
AC_SUBST(ASSEMBLY_PC)

dnl Check for pkg-config
AC_PATH_PROG(PKG_CONFIG, pkg-config, no)
if test "x$PKG_CONFIG" = "xno"; then
	AC_MSG_ERROR(['pkg-config' is not in your PATH.])
fi

NETSTANDARD_REFERENCE_DIR="/usr/lib/mono/xbuild-frameworks/.NETStandard/netstandard2.0"
AC_SUBST(NETSTANDARD_REFERENCE_DIR)

dnl Check for Mono
PKG_CHECK_MODULES(MONO_DEPENDENCY, mono >= 1.0, has_mono=true, has_mono=false)

if test "x$has_mono" = "xtrue"; then
	AC_PATH_PROG(RUNTIME, mono, no)
	AC_PATH_PROG(CSC, csc, no)
	LIB_PREFIX=.so
	LIB_SUFFIX=
else
	AC_PATH_PROG(CSC, csc.exe, no)
	if test x$CSC = "xno"; then
		AC_MSG_ERROR([You need to install either mono or .Net])
	else
		RUNTIME=
		LIB_PREFIX=
		LIB_SUFFIX=.dylib
	fi
fi

CSC="$CSC -nologo -nowarn:CS0649,CS0169 -nostdlib -noconfig -r:${NETSTANDARD_REFERENCE_DIR}/netstandard.dll"

CS="C#"
if test "x$CSC" = "xno" ; then
    AC_MSG_ERROR([No $CS compiler found])
fi

AC_SUBST(RUNTIME)
AC_SUBST(CSC)
AC_SUBST(LIB_PREFIX)
AC_SUBST(LIB_SUFFIX)

dnl Check for gtk-sharp
PKG_CHECK_MODULES(GTK_SHARP, gtk-sharp-3.0)
AC_SUBST(GTK_SHARP_CFLAGS)
AC_SUBST(GTK_SHARP_LIBS)
gtksharp_prefix=`pkg-config --variable=prefix gtk-sharp-3.0`
AC_SUBST(gtksharp_prefix)

dnl Check for gapi
AC_PATH_PROG(GAPI_PARSER, gapi3-parser, no)
if test "x$GAPI_PARSER" = "xno"; then
	AC_MSG_CHECKING(for gapi3-parser.exe)
	GAPI_PARSER=`which gapi3-parser.exe 2> /dev/null`
	if test "x$GAPI_PARSER" = "xno" ; then
		AC_MSG_ERROR(['gapi3_parser'/'gapi3-parser.exe' not found.])
	fi
	AC_MSG_RESULT($GAPI_PARSER)
	GAPI_PARSER="$MONO $GAPI_PARSER"
fi
AC_SUBST(GAPI_PARSER)

AC_PATH_PROG(GAPI_FIXUP, gapi3-fixup, no)
if test "x$GAPI_FIXUP" = "xno"; then
	AC_MSG_CHECKING(for gapi3-fixup.exe)
	GAPI_FIXUP=`which gapi3-fixup.exe 2> /dev/null`
	if test "x$GAPI_FIXUP" = "xno" ; then
		AC_MSG_ERROR(['gapi3_fixup'/'gapi3-fixup.exe' not found.])
	fi
	AC_MSG_RESULT($GAPI_FIXUP)
	GAPI_FIXUP="$MONO $GAPI_FIXUP"
fi
AC_SUBST(GAPI_FIXUP)

AC_PATH_PROG(GAPI_CODEGEN, gapi3-codegen, no)
if test "x$GAPI_CODEGEN" = "xno"; then
	AC_MSG_CHECKING(for gapi3_codegen.exe)
	GAPI_CODEGEN=`which gapi3_codegen.exe 2> /dev/null`
	if test "x$GAPI_CODEGEN" = "xno" ; then
		AC_MSG_ERROR(['gapi3-codegen'/'gapi3_codegen.exe' not found.])
	fi
	AC_MSG_RESULT([$GAPI_CODEGEN])
	GAPI_CODEGEN="$MONO $GAPI_CODEGEN"
fi
AC_SUBST(GAPI_CODEGEN)

dnl Check for Gdl
PKG_CHECK_MODULES(GDL, gdl-3.0)
gdl_prefix=/usr
AC_SUBST(gdl_prefix)



AC_CONFIG_FILES([
	Makefile
	sources/Makefile
	sources/AssemblyInfo.cs
	gdl-sharp-3.pc
	out/gdl-sharp.dll.config
])
AC_CONFIG_COMMANDS([default],[[ echo timestamp > stamp-h ]],[[]])
AC_OUTPUT

echo ""
echo "Configuration summary"
echo "---------------------"
echo ""
echo "   * Installation prefix: $prefix"
echo "   * compiler: $CSC"
echo "   * Documentation:  ($MONODOC)"
echo ""
