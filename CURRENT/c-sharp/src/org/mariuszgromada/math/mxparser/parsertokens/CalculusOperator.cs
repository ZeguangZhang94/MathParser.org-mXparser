﻿/*
 * @(#)CalculusOperator.cs        5.0.0    2022-04-10
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
using System;

namespace org.mariuszgromada.math.mxparser.parsertokens {
	/**
	 * Calculus Operators - mXparser tokens definition.
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
	[CLSCompliant(true)]
	public sealed class CalculusOperator {
		/*
		 * CalculusOperator - token type id.
		 */
		public const int TYPE_ID					= 8;
		public const String TYPE_DESC				= "Calculus Operator";
		/*
		 * CalculusOperator - tokens id.
		 */
		public const int SUM_ID						= 1;
		public const int PROD_ID					= 3;
		public const int INT_ID						= 5;
		public const int DER_ID						= 6;
		public const int DER_LEFT_ID				= 7;
		public const int DER_RIGHT_ID				= 8;
		public const int DERN_ID					= 9;
		public const int FORW_DIFF_ID				= 10;
		public const int BACKW_DIFF_ID				= 11;
		public const int AVG_ID						= 12;
		public const int VAR_ID						= 13;
		public const int STD_ID						= 14;
		public const int MIN_ID						= 15;
		public const int MAX_ID						= 16;
		public const int SOLVE_ID					= 17;
		/*
		 * CalculusOperator - tokens key words.
		 */
		public const String SUM_STR					= "sum";
		public const String SUM_STR_UNI_1			= "∑";
		public const String SUM_STR_UNI_2			= "Σ";
		public const String PROD_STR				= "prod";
		public const String PROD_STR_UNI_1			= "∏";
		public const String PROD_STR_UNI_2			= "ℿ";
		public const String PROD_STR_UNI_3			= "Π";
		public const String INT_STR					= "int";
		public const String INT_STR_UNI_1			= "∫";
		public const String DER_STR					= "der";
		public const String DER_STR_UNI_1			= "∂";
		public const String DER_LEFT_STR			= "der-";
		public const String DER_LEFT_STR_UNI_1		= "∂-";
		public const String DER_RIGHT_STR			= "der+";
		public const String DER_RIGHT_STR_UNI_1		= "∂+";
		public const String DERN_STR				= "dern";
		public const String FORW_DIFF_STR			= "diff";
		public const String FORW_DIFF_STR_UNI_1		= "∆";
		public const String FORW_DIFF_STR_UNI_2		= "Δ";
		public const String BACKW_DIFF_STR			= "difb";
		public const String BACKW_DIFF_STR_UNI_1	= "∇";
		public const String AVG_STR					= "avg";
		public const String VAR_STR					= "vari";
		public const String STD_STR					= "stdi";
		public const String MIN_STR					= "mini";
		public const String MAX_STR					= "maxi";
		public const String SOLVE_STR				= "solve";
		/*
		 * CalculusOperator - syntax.
		 */
		public static readonly String SUM_SYN				= SyntaxStringBuilder.calculusIFromToExprOptBy(SUM_STR);
		public static readonly String SUM_SYN_UNI_1			= SyntaxStringBuilder.calculusIFromToExprOptBy(SUM_STR_UNI_1);
		public static readonly String SUM_SYN_UNI_2			= SyntaxStringBuilder.calculusIFromToExprOptBy(SUM_STR_UNI_2);
		public static readonly String PROD_SYN				= SyntaxStringBuilder.calculusIFromToExprOptBy(PROD_STR);
		public static readonly String PROD_SYN_UNI_1		= SyntaxStringBuilder.calculusIFromToExprOptBy(PROD_STR_UNI_1);
		public static readonly String PROD_SYN_UNI_2		= SyntaxStringBuilder.calculusIFromToExprOptBy(PROD_STR_UNI_2);
		public static readonly String PROD_SYN_UNI_3		= SyntaxStringBuilder.calculusIFromToExprOptBy(PROD_STR_UNI_3);
		public static readonly String INT_SYN				= SyntaxStringBuilder.calculusExprArgFromTo(INT_STR);
		public static readonly String INT_SYN_UNI_1			= SyntaxStringBuilder.calculusExprArgFromTo(INT_STR_UNI_1);
		public static readonly String DER_SYN				= SyntaxStringBuilder.calculusExprArgOptPoint(DER_STR);
		public static readonly String DER_SYN_UNI_1			= SyntaxStringBuilder.calculusExprArgOptPoint(DER_STR_UNI_1);
		public static readonly String DER_LEFT_SYN			= SyntaxStringBuilder.calculusExprArgOptPoint(DER_LEFT_STR);
		public static readonly String DER_LEFT_SYN_UNI_1	= SyntaxStringBuilder.calculusExprArgOptPoint(DER_LEFT_STR_UNI_1);
		public static readonly String DER_RIGHT_SYN			= SyntaxStringBuilder.calculusExprArgOptPoint(DER_RIGHT_STR);
		public static readonly String DER_RIGHT_SYN_UNI_1	= SyntaxStringBuilder.calculusExprArgOptPoint(DER_RIGHT_STR_UNI_1);
		public static readonly String DERN_SYN				= SyntaxStringBuilder.exprNArg(DERN_STR);
		public static readonly String FORW_DIFF_SYN			= SyntaxStringBuilder.calculusExprArgOptDelta(FORW_DIFF_STR);
		public static readonly String FORW_DIFF_SYN_UNI_1	= SyntaxStringBuilder.calculusExprArgOptDelta(FORW_DIFF_STR_UNI_1);
		public static readonly String FORW_DIFF_SYN_UNI_2	= SyntaxStringBuilder.calculusExprArgOptDelta(FORW_DIFF_STR_UNI_2);
		public static readonly String BACKW_DIFF_SYN		= SyntaxStringBuilder.calculusExprArgOptDelta(BACKW_DIFF_STR);
		public static readonly String BACKW_DIFF_SYN_UNI_1	= SyntaxStringBuilder.calculusExprArgOptDelta(BACKW_DIFF_STR_UNI_1);
		public static readonly String AVG_SYN				= SyntaxStringBuilder.calculusIFromToExprOptBy(AVG_STR);
		public static readonly String VAR_SYN				= SyntaxStringBuilder.calculusIFromToExprOptBy(VAR_STR);
		public static readonly String STD_SYN				= SyntaxStringBuilder.calculusIFromToExprOptBy(STD_STR);
		public static readonly String MIN_SYN				= SyntaxStringBuilder.calculusIFromToExprOptBy(MIN_STR);
		public static readonly String MAX_SYN				= SyntaxStringBuilder.calculusIFromToExprOptBy(MAX_STR);
		public static readonly String SOLVE_SYN				= SyntaxStringBuilder.calculusExprArgFromTo(SOLVE_STR);
		/*
		 * CalculusOperator - tokens description.
		 */
		public const String SUM_DESC				= "Summation operator - SIGMA";
		public const String PROD_DESC				= "Product operator - PI";
		public const String INT_DESC				= "Definite integral operator";
		public const String DER_DESC				= "Derivative operator";
		public const String DER_LEFT_DESC			= "Left derivative operator";
		public const String DER_RIGHT_DESC			= "Right derivative operator";
		public const String DERN_DESC				= "n-th derivative operator";
		public const String FORW_DIFF_DESC			= "Forward difference operator";
		public const String BACKW_DIFF_DESC			= "Backward difference operator";
		public const String AVG_DESC				= "Average operator";
		public const String VAR_DESC				= "Bias-corrected sample variance operator";
		public const String STD_DESC				= "Bias-corrected sample standard deviation operator";
		public const String MIN_DESC				= "Minimum value";
		public const String MAX_DESC				= "Maximum value";
		public const String SOLVE_DESC				= "f(x) = 0 equation solving, function root finding";
		/*
		 * CalculusOperator - since.
		 */
		public const String SUM_SINCE				= mXparser.NAMEv10;
		public const String SUM_SINCE_UNI_1			= mXparser.NAMEv50;
		public const String SUM_SINCE_UNI_2			= mXparser.NAMEv50;
		public const String PROD_SINCE				= mXparser.NAMEv10;
		public const String PROD_SINCE_UNI_1		= mXparser.NAMEv50;
		public const String PROD_SINCE_UNI_2		= mXparser.NAMEv50;
		public const String PROD_SINCE_UNI_3		= mXparser.NAMEv50;
		public const String INT_SINCE				= mXparser.NAMEv10;
		public const String INT_SINCE_UNI_1			= mXparser.NAMEv50;
		public const String DER_SINCE				= mXparser.NAMEv10;
		public const String DER_SINCE_UNI_1			= mXparser.NAMEv50;
		public const String DER_LEFT_SINCE			= mXparser.NAMEv10;
		public const String DER_LEFT_SINCE_UNI_1	= mXparser.NAMEv50;
		public const String DER_RIGHT_SINCE			= mXparser.NAMEv10;
		public const String DER_RIGHT_SINCE_UNI_1	= mXparser.NAMEv50;
		public const String DERN_SINCE				= mXparser.NAMEv10;
		public const String FORW_DIFF_SINCE			= mXparser.NAMEv10;
		public const String FORW_DIFF_SINCE_UNI_1	= mXparser.NAMEv50;
		public const String FORW_DIFF_SINCE_UNI_2	= mXparser.NAMEv50;
		public const String BACKW_DIFF_SINCE		= mXparser.NAMEv10;
		public const String BACKW_DIFF_SINCE_UNI_1	= mXparser.NAMEv50;
		public const String AVG_SINCE				= mXparser.NAMEv24;
		public const String VAR_SINCE				= mXparser.NAMEv24;
		public const String STD_SINCE				= mXparser.NAMEv24;
		public const String MIN_SINCE				= mXparser.NAMEv24;
		public const String MAX_SINCE				= mXparser.NAMEv24;
		public const String SOLVE_SINCE				= mXparser.NAMEv40;
	}
}
