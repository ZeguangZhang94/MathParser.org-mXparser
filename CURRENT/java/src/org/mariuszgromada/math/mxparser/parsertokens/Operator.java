/*
 * @(#)Operator.java        5.0.0    2022-04-10
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
package org.mariuszgromada.math.mxparser.parsertokens;

import org.mariuszgromada.math.mxparser.mXparser;
/**
 * Operators - mXparser tokens definition.
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
 */
public final class Operator {
	/*
	 * Operator - token type id.
	 */
	public static final int TYPE_ID 				= 1;
	public static final String TYPE_DESC			= "Operator";
	/*
	 * Operator - tokens id.
	 */
	public static final int PLUS_ID 				= 1;
	public static final int MINUS_ID 				= 2;
	public static final int MULTIPLY_ID 			= 3;
	public static final int DIVIDE_ID 				= 4;
	public static final int POWER_ID 				= 5;
	public static final int FACT_ID					= 6;
	public static final int MOD_ID					= 7;
	public static final int PERC_ID					= 8;
	public static final int TETRATION_ID			= 9;
	public static final int SQUARE_ROOT_ID			= 10;
	public static final int CUBE_ROOT_ID			= 11;
	public static final int FOURTH_ROOT_ID			= 12;
	/*
	 * Operator - tokens key words.
	 */
	public static final String PLUS_STR 			= "+";
	public static final String MINUS_STR 			= "-";
	public static final String MULTIPLY_STR 		= "*";
	public static final String MULTIPLY_STR_UNI_1	= "×";
	public static final String MULTIPLY_STR_UNI_2	= "⨉";
	public static final String MULTIPLY_STR_UNI_3	= "∙";
	public static final String DIVIDE_STR 			= "/";
	public static final String DIVIDE_STR_UNI_1		= "÷";
	public static final String POWER_STR 			= "^";
	public static final String FACT_STR 			= "!";
	public static final String MOD_STR				= "#";
	public static final String PERC_STR				= "%";
	public static final String TETRATION_STR		= "^^";
	public static final String SQUARE_ROOT_STR		= "√";
	public static final String CUBE_ROOT_STR		= "∛";
	public static final String FOURTH_ROOT_STR		= "∜";
	/*
	 * Operator - syntax.
	 */
	public static final String PLUS_SYN 			= SyntaxStringBuilder.binaryOperator(PLUS_STR);
	public static final String MINUS_SYN 			= SyntaxStringBuilder.binaryOperator(MINUS_STR);
	public static final String MULTIPLY_SYN 		= SyntaxStringBuilder.binaryOperator(MULTIPLY_STR);
	public static final String MULTIPLY_SYN_UNI_1	= SyntaxStringBuilder.binaryOperator(MULTIPLY_STR_UNI_1);
	public static final String MULTIPLY_SYN_UNI_2	= SyntaxStringBuilder.binaryOperator(MULTIPLY_STR_UNI_2);
	public static final String MULTIPLY_SYN_UNI_3	= SyntaxStringBuilder.binaryOperator(MULTIPLY_STR_UNI_3);
	public static final String DIVIDE_SYN 			= SyntaxStringBuilder.binaryOperator(DIVIDE_STR);
	public static final String DIVIDE_SYN_UNI_1		= SyntaxStringBuilder.binaryOperator(DIVIDE_STR_UNI_1);
	public static final String POWER_SYN 			= SyntaxStringBuilder.binaryOperatorNoSpace(POWER_STR);
	public static final String FACT_SYN 			= SyntaxStringBuilder.unaryRightOperator(FACT_STR);
	public static final String MOD_SYN				= SyntaxStringBuilder.binaryOperator(MOD_STR);
	public static final String PERC_SYN				= SyntaxStringBuilder.unaryRightOperator(PERC_STR);
	public static final String TETRATION_SYN		= SyntaxStringBuilder.binaryOperatorNoSpace(TETRATION_STR);
	public static final String SQUARE_ROOT_SYN		= SyntaxStringBuilder.unaryLeftOperator(SQUARE_ROOT_STR);
	public static final String CUBE_ROOT_SYN		= SyntaxStringBuilder.unaryLeftOperator(CUBE_ROOT_STR);
	public static final String FOURTH_ROOT_SYN		= SyntaxStringBuilder.unaryLeftOperator(FOURTH_ROOT_STR);
	/*
	 * Operator - tokens description.
	 */
	public static final String PLUS_DESC 			= "Addition";
	public static final String MINUS_DESC 			= "Subtraction";
	public static final String MULTIPLY_DESC 		= "Multiplication";
	public static final String DIVIDE_DESC 			= "Division";
	public static final String POWER_DESC 			= "Exponentiation";
	public static final String FACT_DESC			= "Factorial";
	public static final String MOD_DESC				= "Modulo function";
	public static final String PERC_DESC			= "Percentage";
	public static final String TETRATION_DESC		= "Tetration (hyper-4, power tower, exponential tower)";
	public static final String SQUARE_ROOT_DESC		= "Square root function represented as unary left operator";
	public static final String CUBE_ROOT_DESC		= "Cube root function represented as unary left operator";
	public static final String FOURTH_ROOT_DESC		= "Fourth root function represented as unary left operator";
	/*
	 * Operator - since.
	 */
	public static final String PLUS_SINCE 			= mXparser.NAMEv10;
	public static final String MINUS_SINCE 			= mXparser.NAMEv10;
	public static final String MULTIPLY_SINCE 		= mXparser.NAMEv10;
	public static final String MULTIPLY_SINCE_UNI_1	= mXparser.NAMEv50;
	public static final String MULTIPLY_SINCE_UNI_2	= mXparser.NAMEv50;
	public static final String MULTIPLY_SINCE_UNI_3	= mXparser.NAMEv50;
	public static final String DIVIDE_SINCE 		= mXparser.NAMEv10;
	public static final String DIVIDE_SINCE_UNI_1	= mXparser.NAMEv50;
	public static final String POWER_SINCE 			= mXparser.NAMEv10;
	public static final String FACT_SINCE			= mXparser.NAMEv10;
	public static final String MOD_SINCE			= mXparser.NAMEv10;
	public static final String PERC_SINCE			= mXparser.NAMEv41;
	public static final String TETRATION_SINCE		= mXparser.NAMEv42;
	public static final String SQUARE_ROOT_SINCE	= mXparser.NAMEv50;
	public static final String CUBE_ROOT_SINCE		= mXparser.NAMEv50;
	public static final String FOURTH_ROOT_SINCE	= mXparser.NAMEv50;
}
