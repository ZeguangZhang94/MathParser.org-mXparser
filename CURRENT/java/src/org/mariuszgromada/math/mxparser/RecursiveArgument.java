/*
 * @(#)RecursiveArgument.java        5.0.0    2022-04-10
 *
 * Copyright 2010 - 2022 MARIUSZ GROMADA. All rights reserved.
 *
 * PRODUCT: MathParser.org-mXparser
 * LICENSE: DUAL LICENSE
 *
 * SOFTWARE means source code and/or binary form and/or documentation.
 *
 * BY INSTALLING, COPYING, OR OTHERWISE USING THE SOFTWARE, YOU AGREE TO BE
 * BOUND BY ALL OF THE TERMS AND CONDITIONS OF THE DUAL LICENSE AGREEMENT.
 *
 * MARIUSZ GROMADA provides MathParser.org-mXparser SOFTWARE under the
 * DUAL LICENSE model designed to meet the needs of both Non-Commercial Use
 * as well as Commercial Use.
 *
 * NON-COMMERCIAL USE means any use or activity where a fee is not charged
 * and the purpose is not the sale of a good or service, and the use or
 * activity is not intended to produce a profit. NON-COMMERCIAL USE examples:
 *
 * 1. Free Open-Source Software ("FOSS").
 * 2. Non-commercial use in research, scholarly and education.
 *
 * COMMERCIAL USE means any use or activity where a fee is charged or the
 * purpose is the sale of a good or service, or the use or activity is
 * intended to produce a profit. COMMERCIAL USE examples:
 *
 * 1. OEMs (Original Equipment Manufacturers).
 * 2. ISVs (Independent Software Vendors).
 * 3. VARs (Value Added Resellers).
 * 4. Other distributors that combine and distribute commercially licensed
 *    software.
 *
 * IN CASE YOU WANT TO USE THE SOFTWARE COMMERCIALLY, YOU MUST PURCHASE
 * THE APPROPRIATE LICENSE FROM "INFIMA IWONA GLOWACKA-GROMADA", ONLINE
 * STORE ADDRESS: HTTPS://PAYHIP.COM/INFIMA
 *
 * NON-COMMERCIAL LICENSE
 *
 * Redistribution and use of the PRODUCT in source and/or binary forms, with
 * or without modification, are permitted provided that the following
 * conditions are met:
 *
 * 1. Redistributions of source code must retain unmodified content of the
 *    entire MathParser.org-mXparser DUAL LICENSE, including definition of
 *    NON-COMMERCIAL USE, definition of COMMERCIAL USE, NON-COMMERCIAL
 *    LICENSE conditions, COMMERCIAL LICENSE conditions, and the following
 *    DISCLAIMER.
 * 2. Redistributions in binary form must reproduce the entire content of
 *    MathParser.org-mXparser DUAL LICENSE in the documentation and/or other
 *    materials provided with the distribution, including definition of
 *    NON-COMMERCIAL USE, definition of COMMERCIAL USE, NON-COMMERCIAL
 *    LICENSE conditions, COMMERCIAL LICENSE conditions, and the following
 *    DISCLAIMER.
 *
 * COMMERCIAL LICENSE
 *
 *  1. Before purchasing a commercial license, MARIUSZ GROMADA allows you to
 *     download, install and use up to three copies of the PRODUCT to perform
 *     integration tests, confirm the quality of the PRODUCT and its
 *     suitability. The testing period should be limited to one month. Tests
 *     should take place via test environments. The purpose of the tests must
 *     not be to generate profit.
 *  2. Provided that you purchased a license from "INFIMA IWONA GLOWACKA-GROMADA"
 *     (online store address: https://payhip.com/INFIMA), you comply with all
 *     below terms and conditions, and you have acknowledged and understood the
 *     following DISCLAIMER, MARIUSZ GROMADA grants you a nonexclusive license
 *     including the following rights:
 *  3. In case you purchased a "Single License" You can install and use the
 *     PRODUCT from one workstation.
 *  4. Additional copies of the PRODUCT can be installed and used from more
 *     than one workstation; however, this number is limited to the number of
 *     copies purchased as per order.
 *  5. In case you purchased a "Site License", the PRODUCT can be installed
 *     and used from all workstations located at your premises.
 *  6. You may incorporate the unmodified PRODUCT into your own products and
 *     software.
 *  7. If you purchased a license with the "Source Code" option, you may modify
 *     the PRODUCT's source code and incorporate the modified source code into
 *     your own products and / or software.
 *  8. You may distribute your product and / or software with the incorporated
 *     PRODUCT royalty-free.
 *  9. You may make copies of the PRODUCT for backup and archival purposes.
 * 10. MARIUSZ GROMADA reserves all rights not expressly granted to you in
 *     this agreement.
 *
 * CONTACT
 * - e-mail: info@mathparser.org
 * - website: https://mathparser.org
 * - source code: https://github.com/mariuszgromada/MathParser.org-mXparser
 * - online store: https://payhip.com/INFIMA
 *
 * DISCLAIMER
 *
 * THIS SOFTWARE IS PROVIDED BY MARIUSZ GROMADA "AS IS" AND ANY EXPRESS OR
 * IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
 * OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
 * IN NO EVENT SHALL MATHPARSER.ORG MARIUSZ GROMADA OR CONTRIBUTORS BE LIABLE
 * FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
 * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
 * CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
 * OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE
 * USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 *
 * THE VIEWS AND CONCLUSIONS CONTAINED IN THE SOFTWARE AND DOCUMENTATION ARE
 * THOSE OF THE AUTHORS AND SHOULD NOT BE INTERPRETED AS REPRESENTING OFFICIAL
 * POLICIES, EITHER EXPRESSED OR IMPLIED, OF MARIUSZ GROMADA.
 */
package org.mariuszgromada.math.mxparser;

import java.util.ArrayList;
import java.util.List;
import org.mariuszgromada.math.mxparser.parsertokens.ParserSymbol;
/**
 * RecursiveArgument class enables to declare the argument
 * (variable) which is defined in a recursive way. Such an argument
 * can be used in further processing in expressions, functions and dependent
 * or recursive arguments.<br>
 *
 * For example:
 * <ul>
 * <li>'fib(n) = fin(n-1)+fib(n-2), fib(0) = 0, fib(1) = 1'
 * <li>'factorial(n) = n*factorial(n-1), factorial(0) = 1'
 * </ul>
 * <p>
 * When creating an argument you should avoid:
 * <ul>
 * <li>names reserved as parser keywords, in general words known in mathematical language
 * as function names, operators (for example:
 * sin, cos, +, -, etc...). Please be informed that after associating
 * the argument with the expression, function or dependent/recursive argument
 * its name will be recognized by the parser as reserved key word.
 * It means that it could not be the same as any other key word known
 * by the parser for this particular expression.
 * <li>defining statements with increasing index: 'a(n) = a(n+1) + ... ', otherwise
 * you will get Double.NaN
 * <li>if recursion is not properly defined you will get Double.NaN in the result.
 * This is due to the recursion counter inside of the recursive argument. Calculating
 * n-th element requires no more than n recursion steps (usually less than n).
 * <li>For negative 'n' you will get Double.NaN.
 *
 * </ul>
 *
 * @author         <b>Mariusz Gromada</b><br>
 *                 <a href="https://mathparser.org" target="_blank">MathParser.org - mXparser project page</a><br>
 *                 <a href="https://github.com/mariuszgromada/MathParser.org-mXparser" target="_blank">mXparser on GitHub</a><br>
 *                 <a href="https://payhip.com/INFIMA" target="_blank">INFIMA place to purchase a commercial MathParser.org-mXparser software license</a><br>
 *                 <a href="mailto:info@mathparser.org">info@mathparser.org</a><br>
 *                 <a href="https://scalarmath.org/" target="_blank">ScalarMath.org - a powerful math engine and math scripting language</a><br>
 *                 <a href="https://play.google.com/store/apps/details?id=org.mathparser.scalar.lite" target="_blank">Scalar Lite</a><br>
 *                 <a href="https://play.google.com/store/apps/details?id=org.mathparser.scalar.pro" target="_blank">Scalar Pro</a><br>
 *                 <a href="https://mathspace.pl" target="_blank">MathSpace.pl</a><br>
 *
 * @version        5.0.0
 *
 * @see Argument
 * @see Expression
 * @see Function
 * @see Constant
 */
public class RecursiveArgument extends Argument {
	/**
	 * Type identifier for recursive arguments.
	 */
	public static final int TYPE_ID_RECURSIVE		= 102;
	public static final String TYPE_DESC_RECURSIVE			= "User defined recursive argument";
	/**
	 * Base values
	 */
	private List<Double> baseValues;
	/**
	 * To avoid never ending loops
	 */
	private int recursiveCounter;
	private int startingIndex;
	/**
	 * Constructor - creates recursive argument.
	 *
	 * @param      argumentName                  the argument name
	 * @param      recursiveExpressionString     the recursive expression string
	 * @param      indexName                     index argument name
	 */
	public RecursiveArgument(String argumentName, String recursiveExpressionString, String indexName) {
		super(argumentName, recursiveExpressionString);
		if (argumentName.equals(this.getArgumentName())) {
			this.argumentType = RECURSIVE_ARGUMENT;
			baseValues = new ArrayList<Double>();
			this.n = new Argument(indexName);
			super.argumentExpression.addArguments(n);
			super.argumentExpression.addArguments(this);
			super.argumentExpression.setDescription(argumentName);
			recursiveCounter = -1;
		}
	}
	/**
	 * Constructor - creates recursive argument.
	 *
	 * @param      argumentName                  the argument name
	 * @param      recursiveExpressionString     the recursive expression string
	 * @param      n                             the index argument
	 * @param      elements                      Optional elements list (variadic - comma
	 *                                           separated) of types: Argument, Constant, Function
	 *
	 * @see        PrimitiveElement
	 * @see        Argument
	 */
	public RecursiveArgument(String argumentName, String recursiveExpressionString, Argument n, PrimitiveElement... elements) {
		super(argumentName, recursiveExpressionString);
		if (argumentName.equals(this.getArgumentName())) {
			this.argumentType = RECURSIVE_ARGUMENT;
			baseValues = new ArrayList<Double>();
			this.n = n;
			super.argumentExpression.addArguments(n);
			super.argumentExpression.addArguments(this);
			super.argumentExpression.addDefinitions(elements);
			super.argumentExpression.setDescription(argumentName);
			recursiveCounter = -1;
		}
	}
	/**
	 * Constructor - creates argument based on the argument definition string.
	 *
	 * @param      argumentDefinitionString        Argument definition string, i.e.:
	 *                                             <ul>
	 *                                                <li>'x' - only argument name
	 *                                                <li>'x=5' - argument name and argument value
	 *                                                <li>'x=2*5' - argument name and argument value given as simple expression
	 *                                                <li>'x=2*y' - argument name and argument expression (dependent argument 'x' on argument 'y')
	 *                                                <li>'x(n)=x(n-1)+x(n-2)' - for recursive arguments)
	 *                                             </ul>
	 *
	 * @param      elements                       Optional elements list
	 *                                            (variadic - comma separated) of types: Argument,
	 *                                            Constant, Function
	 *
	 * @see    PrimitiveElement
	 * @see    Argument
	 */
	public RecursiveArgument(String argumentDefinitionString, PrimitiveElement... elements) {
		super(argumentDefinitionString);
		if ( mXparser.regexMatch(argumentDefinitionString, ParserSymbol.function1ArgDefStrRegExp) ) {
			this.argumentType = RECURSIVE_ARGUMENT;
			baseValues = new ArrayList<Double>();
			recursiveCounter = -1;
			super.argumentExpression.addArguments(super.n);
			super.argumentExpression.addArguments(this);
			super.argumentExpression.addDefinitions(elements);
			super.argumentExpression.setDescription(argumentDefinitionString);
		} else {
			super.argumentExpression = new Expression();
			super.argumentExpression.setSyntaxStatus(SYNTAX_ERROR_OR_STATUS_UNKNOWN, "[" + argumentDefinitionString + "] " + "Invalid argument definition (patterns: f(n) = f(n-1) ...  ).");
		}
	}
	/**
	 * Adds base case
	 *
	 * @param      index               the base case index
	 * @param      value               the base case value
	 */
	public void addBaseCase(int index, double value) {
		int recSize = baseValues.size();
		if (index > recSize-1) {
			/*
			 * Expand base values array if necessary
			 */
			for (int i = recSize; i < index; i++)
				baseValues.add(Double.NaN);
			baseValues.add(value);
		} else
			baseValues.set(index, value);
	}
	/**
	 * Clears all based cases and stored calculated values
	 */
	public void resetAllCases() {
		baseValues.clear();
		recursiveCounter = -1;
	}
	/**
	 * Gets recursive argument value
	 *
	 * @param      index               the index
	 *
	 * @return     value as double
	 */
	public double getArgumentValue(double index) {
		/*
		 * Remember starting index
		 */
		if (recursiveCounter == -1)
			startingIndex = (int)Math.round(index);
		int recSize = baseValues.size();
		int idx = (int)Math.round(index);
		/*
		 * Count recursive calls
		 */
		recursiveCounter++;
		if ((recursiveCounter <= startingIndex) && (idx <= startingIndex)) {
			/*
			 * if recursive counter is still lower than starting index
			 * and current index is not increasing
			 */
			if ((idx >= 0) && (idx < recSize) && (!Double.isNaN(baseValues.get(idx).doubleValue())) ) {
				/*
				 * decrease recursive counter and return value
				 * if recursive value for the current index was already
				 * calculated and remembered in the base values table
				 */
				recursiveCounter--;
				return baseValues.get(idx).doubleValue();
			}
			else if (idx >= 0) {
				/*
				 * value is to be calculated by the recursive calls
				 */
				/*
				 * Set n to the current index
				 */
				n.setArgumentValue(idx);
				/*
				 * create new expression
				 */
				Expression newExp = new Expression(
						super.argumentExpression.expressionString
						,super.argumentExpression.argumentsList
						,super.argumentExpression.functionsList
						,super.argumentExpression.constantsList
						,Expression.INTERNAL
						,super.argumentExpression.UDFExpression
						,super.argumentExpression.UDFVariadicParamsAtRunTime);
				newExp.setDescription(super.getArgumentName());
				if (super.getVerboseMode() == true)
					newExp.setVerboseMode();
				/*
				 * perform recursive call
				 */
				double value = newExp.calculate();
				/*
				 * remember calculated in the base values array
				 */
				addBaseCase(idx, value);
				/*
				 * decrease recursive counter and return value
				 */
				recursiveCounter--;
				return value;
			} else {
				/*
				 * decrease recursive counter and
				 * return Double.NaN for negative index call
				 */
				recursiveCounter--;
				return Double.NaN;
			}
		} else {
			/* stop never ending loop
			 * decrease recursive counter and
			 * return Double.NaN
			 */
			recursiveCounter--;
			return Double.NaN;
		}
	}
}